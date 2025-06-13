namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            lblName = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            btnGet = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnGetById = new Button();
            groupBoxActions = new GroupBox();
            groupBoxInfo = new GroupBox();
            groupBoxSearch = new GroupBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxActions.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 80);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(852, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 90);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 60);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 60);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Tên sản phẩm:";
            lblName.Click += label1_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 63);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(27, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Giá:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 93);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(41, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Mô tả:";
            // 
            // btnGet
            // 
            btnGet.BackColor = Color.LightBlue;
            btnGet.Location = new Point(20, 30);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(120, 35);
            btnGet.TabIndex = 7;
            btnGet.Text = "Lấy danh sách";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Location = new Point(160, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightYellow;
            btnEdit.Location = new Point(300, 30);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Location = new Point(580, 30);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 35);
            btnClear.TabIndex = 10;
            btnClear.Text = "Xóa danh sách";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightPink;
            btnDelete.Location = new Point(440, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(120, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sản phẩm cần tìm...";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 28);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 15);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.LightCyan;
            btnGetById.Location = new Point(350, 20);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(120, 35);
            btnGetById.TabIndex = 14;
            btnGetById.Text = "Xem chi tiết";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // groupBoxActions
            // 
            groupBoxActions.Controls.Add(btnGet);
            groupBoxActions.Controls.Add(btnAdd);
            groupBoxActions.Controls.Add(btnEdit);
            groupBoxActions.Controls.Add(btnDelete);
            groupBoxActions.Controls.Add(btnClear);
            groupBoxActions.Location = new Point(20, 480);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(852, 80);
            groupBoxActions.TabIndex = 15;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Chức năng";
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblName);
            groupBoxInfo.Controls.Add(txtName);
            groupBoxInfo.Controls.Add(lblPrice);
            groupBoxInfo.Controls.Add(txtPrice);
            groupBoxInfo.Controls.Add(lblDescription);
            groupBoxInfo.Controls.Add(txtDescription);
            groupBoxInfo.Location = new Point(20, 300);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(350, 170);
            groupBoxInfo.TabIndex = 16;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin sản phẩm";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(lblSearch);
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Controls.Add(btnGetById);
            groupBoxSearch.Location = new Point(390, 300);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(482, 170);
            groupBoxSearch.TabIndex = 17;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Tìm kiếm & Chi tiết";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 30);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 580);
            Controls.Add(lblTitle);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxInfo);
            Controls.Add(groupBoxActions);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm - WinForms App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxActions.ResumeLayout(false);
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Label lblName;
        private Label lblPrice;
        private Label lblDescription;
        private Button btnGet;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnClear;
        private Button btnDelete;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnGetById;
        private GroupBox groupBoxActions;
        private GroupBox groupBoxInfo;
        private GroupBox groupBoxSearch;
        private Label lblTitle;
    }
}