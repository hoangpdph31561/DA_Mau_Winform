namespace WinForms_view_layer
{
    partial class FormDangNhap
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtInputEmai = new TextBox();
            label2 = new Label();
            txtInputPassword = new TextBox();
            chkbRememberAccount = new CheckBox();
            btnForgetPassword = new Button();
            btnLogin = new Button();
            btnOut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cb_logo_clipart_2;
            pictureBox1.Location = new Point(197, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 182);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập emai";
            // 
            // txtInputEmai
            // 
            txtInputEmai.Location = new Point(79, 221);
            txtInputEmai.Name = "txtInputEmai";
            txtInputEmai.PlaceholderText = "Email của bạn";
            txtInputEmai.Size = new Size(409, 27);
            txtInputEmai.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 267);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // txtInputPassword
            // 
            txtInputPassword.Location = new Point(79, 306);
            txtInputPassword.Name = "txtInputPassword";
            txtInputPassword.PasswordChar = '*';
            txtInputPassword.PlaceholderText = "Mật khẩu của bạn";
            txtInputPassword.Size = new Size(409, 27);
            txtInputPassword.TabIndex = 4;
            // 
            // chkbRememberAccount
            // 
            chkbRememberAccount.AutoSize = true;
            chkbRememberAccount.Location = new Point(79, 361);
            chkbRememberAccount.Name = "chkbRememberAccount";
            chkbRememberAccount.Size = new Size(147, 24);
            chkbRememberAccount.TabIndex = 5;
            chkbRememberAccount.Text = "Ghi nhớ tài khoản";
            chkbRememberAccount.UseVisualStyleBackColor = true;
            // 
            // btnForgetPassword
            // 
            btnForgetPassword.BackColor = SystemColors.Control;
            btnForgetPassword.FlatAppearance.BorderSize = 0;
            btnForgetPassword.Location = new Point(323, 361);
            btnForgetPassword.Name = "btnForgetPassword";
            btnForgetPassword.Size = new Size(165, 29);
            btnForgetPassword.TabIndex = 6;
            btnForgetPassword.Text = "Quên mật khẩu";
            btnForgetPassword.UseVisualStyleBackColor = false;
            btnForgetPassword.Click += btnForgetPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(145, 414);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(259, 47);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(145, 477);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(259, 47);
            btnOut.TabIndex = 8;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(594, 539);
            Controls.Add(btnOut);
            Controls.Add(btnLogin);
            Controls.Add(btnForgetPassword);
            Controls.Add(chkbRememberAccount);
            Controls.Add(txtInputPassword);
            Controls.Add(label2);
            Controls.Add(txtInputEmai);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtInputEmai;
        private Label label2;
        private TextBox txtInputPassword;
        private CheckBox chkbRememberAccount;
        private Button btnForgetPassword;
        private Button btnLogin;
        private Button btnOut;
    }
}