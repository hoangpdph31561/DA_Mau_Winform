namespace WinForms_view_layer.FormCustomer
{
    partial class FormCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            txtNameCustomer = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            dtgCustomer = new DataGridView();
            txtFind = new TextBox();
            btnFind = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnPass = new Button();
            btnList = new Button();
            btnOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1007, 55);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 160);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(186, 77);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 27);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtNameCustomer
            // 
            txtNameCustomer.Location = new Point(186, 157);
            txtNameCustomer.Name = "txtNameCustomer";
            txtNameCustomer.Size = new Size(248, 27);
            txtNameCustomer.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 84);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(686, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(277, 27);
            txtAddress.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 160);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Giới tính";
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(734, 158);
            radMale.Name = "radMale";
            radMale.Size = new Size(62, 24);
            radMale.TabIndex = 8;
            radMale.TabStop = true;
            radMale.Text = "Nam";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(855, 158);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(50, 24);
            radFemale.TabIndex = 9;
            radFemale.TabStop = true;
            radFemale.Text = "Nữ";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // dtgCustomer
            // 
            dtgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomer.Location = new Point(79, 226);
            dtgCustomer.Name = "dtgCustomer";
            dtgCustomer.RowHeadersWidth = 51;
            dtgCustomer.RowTemplate.Height = 29;
            dtgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCustomer.Size = new Size(884, 188);
            dtgCustomer.TabIndex = 10;
            dtgCustomer.CellClick += dtgCustomer_CellClick;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(280, 444);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Nhập số điện thoại khách hàng";
            txtFind.Size = new Size(283, 27);
            txtFind.TabIndex = 11;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(608, 443);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 12;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(79, 529);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 529);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 44);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(341, 529);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 44);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(472, 529);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 44);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPass
            // 
            btnPass.Location = new Point(603, 529);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(94, 44);
            btnPass.TabIndex = 17;
            btnPass.Text = "Bỏ qua";
            btnPass.UseVisualStyleBackColor = true;
            btnPass.Click += btnPass_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(734, 529);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 44);
            btnList.TabIndex = 18;
            btnList.Text = "Danh sách";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(865, 529);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(94, 44);
            btnOut.TabIndex = 19;
            btnOut.Text = "Đóng";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 602);
            Controls.Add(btnOut);
            Controls.Add(btnList);
            Controls.Add(btnPass);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Controls.Add(dtgCustomer);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtNameCustomer);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPhoneNumber;
        private TextBox txtNameCustomer;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private RadioButton radMale;
        private RadioButton radFemale;
        private DataGridView dtgCustomer;
        private TextBox txtFind;
        private Button btnFind;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnPass;
        private Button btnList;
        private Button btnOut;
    }
}