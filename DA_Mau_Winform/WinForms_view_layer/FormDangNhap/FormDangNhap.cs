using DA_mau_BussinessLayer.Catalog.Employee;
using DA_mau_Utilities.EmployeeRequest;
using DA_mau_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_view_layer.MailLayout;

namespace WinForms_view_layer
{

    public partial class FormDangNhap : Form
    {
        FormMainScreen mainScreen = new FormMainScreen();
        private readonly ManageEmployeeService manageEmployeeService = new ManageEmployeeService();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            LoginRequest request = new LoginRequest()
            {
                Email = txtInputEmai.Text,
                Password = txtInputPassword.Text,
            };
            var result = await manageEmployeeService.Login(request);
            if (result.IsSuccess)
            {
                FormMainScreen._mail = result.Email;
                FormMainScreen._role = (Role)result.Role;
                FormMainScreen._employeeId = result.Id;
                MessageBox.Show("Đăng nhập thành công");
                FormMainScreen._session = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnForgetPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInputEmai.Text))
            {
                var emailRequest = new ForgetPasswordRequest()
                {
                    Email = txtInputEmai.Text,
                };

                var result = await manageEmployeeService.ForgetPassword(emailRequest);
                if (result)
                {
                    MessageBox.Show("Newpassword has been send to your email");
                }
                else
                {
                    MessageBox.Show("Email không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nhập email đê");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show("Bạn chắc chắn muốn thoát đăng nhập?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            FormMainScreen._session = 0;
        }
    }
}
