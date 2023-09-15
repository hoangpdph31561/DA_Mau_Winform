using DA_mau_BussinessLayer.Catalog.Employee;
using DA_mau_Utilities.EmployeeRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_view_layer
{

    public partial class FormDangNhap : Form
    {
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
            bool result = await manageEmployeeService.Login(request);
            if (result)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private async void btnForgetPassword_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInputEmai.Text))
            {
                var emailRequest = new ForgetPasswordRequest()
                {
                    Email = txtInputEmai.Text,
                };
                
                var result =await manageEmployeeService.ForgetPassword(emailRequest);
                if(result)
                {
                    MessageBox.Show("Newpassword has been send to your email");
                }
                else
                {
                    MessageBox.Show("Bạn chưa đăng ký nên không tồn tại mail","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
