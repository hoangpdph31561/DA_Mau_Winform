﻿namespace WinForms_view_layer
{
    partial class FormEmployee
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
            txtEmail = new TextBox();
            txtEmployeeName = new TextBox();
            groupBox1 = new GroupBox();
            radManager = new RadioButton();
            radEmployee = new RadioButton();
            label5 = new Label();
            groupBox2 = new GroupBox();
            radInActive = new RadioButton();
            radActive = new RadioButton();
            label6 = new Label();
            txtAddress = new Label();
            richTextBox1 = new RichTextBox();
            dtgNhanVien = new DataGridView();
            textBox3 = new TextBox();
            btnFind = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnPass = new Button();
            btnList = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1034, 50);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 72);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 128);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên nhân viên";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(155, 125);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(282, 27);
            txtEmployeeName.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radManager);
            groupBox1.Controls.Add(radEmployee);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(60, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 73);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // radManager
            // 
            radManager.AutoSize = true;
            radManager.Location = new Point(260, 33);
            radManager.Name = "radManager";
            radManager.Size = new Size(83, 24);
            radManager.TabIndex = 2;
            radManager.TabStop = true;
            radManager.Text = "Quản trị";
            radManager.UseVisualStyleBackColor = true;
            // 
            // radEmployee
            // 
            radEmployee.AutoSize = true;
            radEmployee.Location = new Point(101, 33);
            radEmployee.Name = "radEmployee";
            radEmployee.Size = new Size(96, 24);
            radEmployee.TabIndex = 1;
            radEmployee.TabStop = true;
            radEmployee.Text = "Nhân viên";
            radEmployee.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 0;
            label5.Text = "Vai trò";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radInActive);
            groupBox2.Controls.Add(radActive);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(604, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 73);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // radInActive
            // 
            radInActive.AutoSize = true;
            radInActive.Location = new Point(213, 33);
            radInActive.Name = "radInActive";
            radInActive.Size = new Size(149, 24);
            radInActive.TabIndex = 2;
            radInActive.TabStop = true;
            radInActive.Text = "Ngừng hoạt động";
            radInActive.UseVisualStyleBackColor = true;
            // 
            // radActive
            // 
            radActive.AutoSize = true;
            radActive.Location = new Point(105, 33);
            radActive.Name = "radActive";
            radActive.Size = new Size(102, 24);
            radActive.TabIndex = 1;
            radActive.TabStop = true;
            radActive.Text = "Hoạt động";
            radActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 35);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 0;
            label6.Text = "Tính trạng";
            // 
            // txtAddress
            // 
            txtAddress.AutoSize = true;
            txtAddress.Location = new Point(604, 76);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(55, 20);
            txtAddress.TabIndex = 7;
            txtAddress.Text = "Địa chỉ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(690, 76);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(291, 76);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // dtgNhanVien
            // 
            dtgNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNhanVien.Location = new Point(60, 273);
            dtgNhanVien.Name = "dtgNhanVien";
            dtgNhanVien.RowHeadersWidth = 51;
            dtgNhanVien.RowTemplate.Height = 29;
            dtgNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgNhanVien.Size = new Size(921, 188);
            dtgNhanVien.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 515);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 27);
            textBox3.TabIndex = 10;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(626, 513);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 11;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 579);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 48);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 579);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 48);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(326, 579);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 48);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(462, 579);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 48);
            btnSave.TabIndex = 15;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPass
            // 
            btnPass.Location = new Point(598, 579);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(107, 48);
            btnPass.TabIndex = 16;
            btnPass.Text = "Bỏ qua";
            btnPass.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.Location = new Point(734, 579);
            btnList.Name = "btnList";
            btnList.Size = new Size(107, 48);
            btnList.TabIndex = 17;
            btnList.Text = "Danh sách";
            btnList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(870, 579);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 48);
            btnClose.TabIndex = 18;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 669);
            Controls.Add(btnClose);
            Controls.Add(btnList);
            Controls.Add(btnPass);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnFind);
            Controls.Add(textBox3);
            Controls.Add(dtgNhanVien);
            Controls.Add(richTextBox1);
            Controls.Add(txtAddress);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployee";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtEmployeeName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label txtAddress;
        private RadioButton radManager;
        private RadioButton radEmployee;
        private Label label5;
        private RadioButton radInActive;
        private RadioButton radActive;
        private Label label6;
        private RichTextBox richTextBox1;
        private DataGridView dtgNhanVien;
        private TextBox textBox3;
        private Button btnFind;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnPass;
        private Button btnList;
        private Button btnClose;
    }
}