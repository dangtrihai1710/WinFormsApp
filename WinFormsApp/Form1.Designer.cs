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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(255, 272);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(255, 330);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(255, 301);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(149, 272);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Tên sản phẩm:";
            lblName.Click += label1_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(149, 301);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(27, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Giá:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(149, 333);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(41, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Mô tả:";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(414, 200);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(135, 23);
            btnGet.TabIndex = 7;
            btnGet.Text = "Lấy danh sách";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(205, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(312, 200);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(55, 200);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Xóa ds";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(582, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnGet);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
