namespace WinForms_view_layer
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
            components = new System.ComponentModel.Container();
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
            labelAddress = new Label();
            txtEmployeeAddress = new RichTextBox();
            dtgNhanVien = new DataGridView();
            txtFind = new TextBox();
            btnFind = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnPass = new Button();
            btnList = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).BeginInit();
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
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(604, 76);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(55, 20);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Địa chỉ";
            // 
            // txtEmployeeAddress
            // 
            txtEmployeeAddress.Location = new Point(690, 76);
            txtEmployeeAddress.Name = "txtEmployeeAddress";
            txtEmployeeAddress.Size = new Size(291, 76);
            txtEmployeeAddress.TabIndex = 8;
            txtEmployeeAddress.Text = "";
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
            dtgNhanVien.CellClick += dtgNhanVien_CellClick;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(245, 515);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(318, 27);
            txtFind.TabIndex = 10;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(626, 513);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 11;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 579);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 48);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 579);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 48);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(326, 579);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 48);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(462, 579);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 48);
            btnSave.TabIndex = 15;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPass
            // 
            btnPass.Location = new Point(598, 579);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(107, 48);
            btnPass.TabIndex = 16;
            btnPass.Text = "Bỏ qua";
            btnPass.UseVisualStyleBackColor = true;
            btnPass.Click += btnPass_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(734, 579);
            btnList.Name = "btnList";
            btnList.Size = new Size(107, 48);
            btnList.TabIndex = 17;
            btnList.Text = "Danh sách";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(870, 579);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 48);
            btnClose.TabIndex = 18;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            Controls.Add(txtFind);
            Controls.Add(dtgNhanVien);
            Controls.Add(txtEmployeeAddress);
            Controls.Add(labelAddress);
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
            Load += FormEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Label labelAddress;
        private RadioButton radManager;
        private RadioButton radEmployee;
        private Label label5;
        private RadioButton radInActive;
        private RadioButton radActive;
        private Label label6;
        private RichTextBox txtEmployeeAddress;
        private DataGridView dtgNhanVien;
        private TextBox txtFind;
        private Button btnFind;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnPass;
        private Button btnList;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}