using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:5041/api/products";
        private int selectedProductId = 0;
        private List<Product> allProducts = new List<Product>(); // Lưu toàn bộ danh sách để tìm kiếm

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Không cần code gì ở đây
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                selectedProductId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                txtName.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                txtPrice.Text = selectedRow.Cells["Price"].Value?.ToString() ?? "";
                txtDescription.Text = selectedRow.Cells["Description"].Value?.ToString() ?? "";
            }
        }

        // Chức năng tìm kiếm theo tên
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // Hiển thị toàn bộ danh sách khi không có từ khóa tìm kiếm
                dataGridView1.DataSource = allProducts;
            }
            else
            {
                // Lọc sản phẩm theo tên
                var filteredProducts = allProducts.Where(p =>
                    p.Name.ToLower().Contains(searchText)).ToList();
                dataGridView1.DataSource = filteredProducts;
            }

            // Cập nhật tên cột sau khi thay đổi DataSource
            UpdateColumnHeaders();
        }

        // Lấy sản phẩm theo ID
        private async void btnGetById_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xem chi tiết!", "Thông báo");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"{BaseUrl}/{selectedProductId}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var product = JsonSerializer.Deserialize<Product>(jsonString, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (product != null)
                    {
                        // Hiển thị thông tin sản phẩm
                        MessageBox.Show($"Thông tin sản phẩm:\n" +
                                      $"ID: {product.Id}\n" +
                                      $"Tên: {product.Name}\n" +
                                      $"Giá: {product.Price:C}\n" +
                                      $"Mô tả: {product.Description}",
                                      "Chi tiết sản phẩm");
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy sản phẩm với ID: {selectedProductId}", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy thông tin sản phẩm: {ex.Message}", "Lỗi");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var response = await _httpClient.DeleteAsync($"{BaseUrl}/{selectedProductId}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
                        ClearForm();
                        await LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi khi xóa sản phẩm: {response.StatusCode}", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            await LoadProducts();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!", "Thông báo");
                return;
            }

            try
            {
                var product = new Product
                {
                    Id = selectedProductId,
                    Name = txtName.Text.Trim(),
                    Price = price,
                    Description = txtDescription.Text.Trim()
                };

                var jsonString = JsonSerializer.Serialize(product);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{BaseUrl}/{selectedProductId}", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo");
                    ClearForm();
                    await LoadProducts();
                }
                else
                {
                    MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {response.StatusCode}", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!", "Thông báo");
                return;
            }

            try
            {
                var product = new Product
                {
                    Name = txtName.Text.Trim(),
                    Price = price,
                    Description = txtDescription.Text.Trim()
                };

                var jsonString = JsonSerializer.Serialize(product);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(BaseUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                    ClearForm();
                    await LoadProducts();
                }
                else
                {
                    MessageBox.Show($"Lỗi khi thêm sản phẩm: {response.StatusCode}", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        // Chức năng xóa danh sách (Clear form và reset DataGridView)
        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa toàn bộ danh sách hiển thị không?",
                                       "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa danh sách hiển thị
                dataGridView1.DataSource = null;
                allProducts.Clear();

                // Xóa thông tin trong form
                ClearForm();

                // Xóa text tìm kiếm
                txtSearch.Clear();

                MessageBox.Show("Đã xóa danh sách hiển thị!", "Thông báo");
            }
        }

        // Các method hỗ trợ
        private async Task LoadProducts()
        {
            try
            {
                var response = await _httpClient.GetAsync(BaseUrl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var products = JsonSerializer.Deserialize<List<Product>>(jsonString, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    allProducts = products ?? new List<Product>();
                    dataGridView1.DataSource = allProducts;

                    UpdateColumnHeaders();
                }
                else
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {response.StatusCode}", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}\n\nVui lòng kiểm tra:\n1. WebAPI đã chạy chưa?\n2. URL có đúng không?", "Lỗi kết nối");
            }
        }

        private void UpdateColumnHeaders()
        {
            // Đặt tên cột tiếng Việt
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].HeaderText = "Mã SP";
                dataGridView1.Columns["Name"].HeaderText = "Tên sản phẩm";
                dataGridView1.Columns["Price"].HeaderText = "Giá";
                dataGridView1.Columns["Description"].HeaderText = "Mô tả";

                // Tự động điều chỉnh độ rộng cột
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ClearForm()
        {
            selectedProductId = 0;
            txtName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _httpClient?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    // Product model class
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}