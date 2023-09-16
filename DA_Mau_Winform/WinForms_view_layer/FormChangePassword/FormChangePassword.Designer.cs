namespace WinForms_view_layer.FormChangePassword
{
    partial class FormChangePassword
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
            label4 = new Label();
            label5 = new Label();
            txtEmailEmployee = new TextBox();
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnConfirmChangePass = new Button();
            btnOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(476, 54);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 93);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Email nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 184);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 275);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 366);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Nhập lại mật khẩu mới";
            // 
            // txtEmailEmployee
            // 
            txtEmailEmployee.Enabled = false;
            txtEmailEmployee.Location = new Point(52, 135);
            txtEmailEmployee.Name = "txtEmailEmployee";
            txtEmailEmployee.ReadOnly = true;
            txtEmailEmployee.Size = new Size(334, 27);
            txtEmailEmployee.TabIndex = 5;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(52, 226);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(334, 27);
            txtOldPassword.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(52, 317);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(334, 27);
            txtNewPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(52, 408);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(334, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // btnConfirmChangePass
            // 
            btnConfirmChangePass.Location = new Point(120, 457);
            btnConfirmChangePass.Name = "btnConfirmChangePass";
            btnConfirmChangePass.Size = new Size(224, 42);
            btnConfirmChangePass.TabIndex = 9;
            btnConfirmChangePass.Text = "Đổi mật khẩu";
            btnConfirmChangePass.UseVisualStyleBackColor = true;
            btnConfirmChangePass.Click += btnConfirmChangePass_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(120, 520);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(224, 42);
            btnOut.TabIndex = 10;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // FormChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 587);
            Controls.Add(btnOut);
            Controls.Add(btnConfirmChangePass);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(txtEmailEmployee);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChangePassword";
            Load += FormChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmailEmployee;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnConfirmChangePass;
        private Button btnOut;
    }
}