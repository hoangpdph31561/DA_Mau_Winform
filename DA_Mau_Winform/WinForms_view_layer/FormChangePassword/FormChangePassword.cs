using DA_mau_BussinessLayer.Catalog.Employee;
using DA_mau_Utilities.EmployeeRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_view_layer.MailLayout;

namespace WinForms_view_layer.FormChangePassword
{
    public partial class FormChangePassword : Form
    {
        private readonly ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private async void btnConfirmChangePass_Click(object sender, EventArgs e)
        {
            ChangePasswordRequest request = new ChangePasswordRequest();
            request.Email = FormMainScreen._mail;
            request.OldPassword = txtOldPassword.Text;
            request.NewPassword = txtNewPassword.Text;
            request.ConfirmPassword = txtConfirmPassword.Text;
            if (!Regex.IsMatch(txtNewPassword.Text, @"^[\w\d]{5,}$"))
            {
                MessageBox.Show("Mật khẩu phải từ 5 ký tự trở lên");
                return;
            }
            DialogResult reg = MessageBox.Show("Bạn có thực sự muốn đổi mật khẩu", "Xác nhận đổi mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                var result = await manageEmployeeService.ChangePassword(request);
                if (result)
                {
                    FormMainScreen._profile = 1;
                    FormMainScreen._session = 0;
                    MessageBox.Show("Mật khẩu mới cập nhật thành công, bạn phải đăng nhập lại");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Điền cái gì đó sai mất rồi", "Lỗi không đổi được", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            txtEmailEmployee.Text = FormMainScreen._mail;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
