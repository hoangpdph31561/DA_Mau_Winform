namespace WinForms_view_layer
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtProductQuantity = new TextBox();
            txtProductInputPrice = new TextBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txtProductNote = new RichTextBox();
            label7 = new Label();
            btnOpenImage = new Button();
            dgvProduct = new DataGridView();
            txtFind = new TextBox();
            btnFind = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnPass = new Button();
            btnList = new Button();
            btnClose = new Button();
            label8 = new Label();
            txtProductSellPrice = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1047, 55);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 55);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 113);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 171);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 229);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá nhập";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(134, 52);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(289, 27);
            txtProductId.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(134, 110);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(289, 27);
            txtProductName.TabIndex = 6;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(134, 168);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(289, 27);
            txtProductQuantity.TabIndex = 7;
            // 
            // txtProductInputPrice
            // 
            txtProductInputPrice.Location = new Point(134, 222);
            txtProductInputPrice.Name = "txtProductInputPrice";
            txtProductInputPrice.Size = new Size(289, 27);
            txtProductInputPrice.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(623, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 206);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "Ghi chú";
            // 
            // txtProductNote
            // 
            txtProductNote.Location = new Point(623, 203);
            txtProductNote.Name = "txtProductNote";
            txtProductNote.Size = new Size(256, 104);
            txtProductNote.TabIndex = 11;
            txtProductNote.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 59);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 12;
            label7.Text = "Hình";
            // 
            // btnOpenImage
            // 
            btnOpenImage.Location = new Point(910, 59);
            btnOpenImage.Name = "btnOpenImage";
            btnOpenImage.Size = new Size(94, 29);
            btnOpenImage.TabIndex = 13;
            btnOpenImage.Text = "Mở hình";
            btnOpenImage.UseVisualStyleBackColor = true;
            btnOpenImage.Click += btnOpenImage_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(29, 345);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(975, 188);
            dgvProduct.TabIndex = 14;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(262, 583);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(305, 27);
            txtFind.TabIndex = 15;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(636, 581);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 16;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 632);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 51);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(171, 632);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 51);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(313, 632);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 51);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(455, 632);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 51);
            btnSave.TabIndex = 20;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPass
            // 
            btnPass.Location = new Point(597, 632);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(118, 51);
            btnPass.TabIndex = 21;
            btnPass.Text = "Bỏ qua";
            btnPass.UseVisualStyleBackColor = true;
            btnPass.Click += btnPass_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(739, 632);
            btnList.Name = "btnList";
            btnList.Size = new Size(118, 51);
            btnList.TabIndex = 22;
            btnList.Text = "Danh sách";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(881, 632);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 51);
            btnClose.TabIndex = 23;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 287);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 24;
            label8.Text = "Đơn giá bán";
            // 
            // txtProductSellPrice
            // 
            txtProductSellPrice.Location = new Point(134, 280);
            txtProductSellPrice.Name = "txtProductSellPrice";
            txtProductSellPrice.Size = new Size(289, 27);
            txtProductSellPrice.TabIndex = 25;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 712);
            Controls.Add(txtProductSellPrice);
            Controls.Add(label8);
            Controls.Add(btnClose);
            Controls.Add(btnList);
            Controls.Add(btnPass);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Controls.Add(dgvProduct);
            Controls.Add(btnOpenImage);
            Controls.Add(label7);
            Controls.Add(txtProductNote);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtProductInputPrice);
            Controls.Add(txtProductQuantity);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtProductQuantity;
        private TextBox txtProductInputPrice;
        private PictureBox pictureBox1;
        private Label label6;
        private RichTextBox txtProductNote;
        private Label label7;
        private Button btnOpenImage;
        private DataGridView dgvProduct;
        private TextBox txtFind;
        private Button btnFind;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnPass;
        private Button btnList;
        private Button btnClose;
        private Label label8;
        private TextBox txtProductSellPrice;
        private ErrorProvider errorProvider1;
    }
}