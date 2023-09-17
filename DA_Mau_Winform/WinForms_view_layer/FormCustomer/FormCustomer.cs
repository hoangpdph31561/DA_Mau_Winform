using DA_mau_BussinessLayer.Catalog.Customer;
using DA_mau_Utilities.CustomerRequest;
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

namespace WinForms_view_layer.FormCustomer
{
    public partial class FormCustomer : Form
    {
        private int _columnCount;
        private readonly ManagerCustomer managerCustomer = new ManagerCustomer();
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadGrid(null);
        }
        private void ResetValue()
        {
            txtPhoneNumber.Text = null;
            txtAddress.Text = null;
            txtNameCustomer.Text = null;
            txtFind.Text = string.Empty;
            txtPhoneNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtNameCustomer.Enabled = false;
            radFemale.Enabled = false;
            radMale.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
        }
        private async void LoadGrid(string? phoneNumber)
        {
            int soThuTu = 1;
            dtgCustomer.ColumnCount = 6;
            dtgCustomer.Columns[0].Name = "Số thứ tự";
            dtgCustomer.Columns[1].Name = "Điện thoại";
            dtgCustomer.Columns[2].Name = "Họ và tên";
            dtgCustomer.Columns[3].Name = "Địa chỉ";
            dtgCustomer.Columns[4].Name = "Giới tính";
            dtgCustomer.Columns[5].Name = "Nhân viên nhập";
            dtgCustomer.Rows.Clear();
            if (phoneNumber == null)
            {
                var data = await managerCustomer.GetAll(null);
                _columnCount = data.Count();
                foreach (var item in data)
                {
                    dtgCustomer.Rows.Add(soThuTu++, item.PhoneNumber, item.Name, item.Address, Enum.GetName(typeof(Gender), item.Gender), item.EmployeeName);
                }
            }
            else
            {
                var data = await managerCustomer.GetAll(phoneNumber);
                _columnCount = data.Count();
                foreach (var item in data)
                {
                    dtgCustomer.Rows.Add(soThuTu++, item.PhoneNumber, item.Name, item.Address, Enum.GetName(typeof(Gender), item.Gender), item.EmployeeName);
                }
            }
        }
        private void EnableTxt()
        {
            txtPhoneNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNameCustomer.Text = string.Empty;
            txtPhoneNumber.Enabled = true;
            txtAddress.Enabled = true;
            txtNameCustomer.Enabled = true;
            radFemale.Enabled = true;
            radMale.Enabled = true;
            radMale.Checked = true;
            radFemale.Checked = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableTxt();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            CreateNewCustomerRequest request = new()
            {
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text,
                Name = txtNameCustomer.Text,
            };
            request.EmployeeId = FormMainScreen._employeeId;
            if (radFemale.Checked)
            {
                request.Gender = Gender.Female;
            }
            else
            {
                request.Gender = Gender.Male;
            }
            var result = await managerCustomer.CreateNewCustomer(request);
            if (result)
            {
                MessageBox.Show("Tạo mới thành công");
                LoadGrid(null);
                EnableTxt();
            }
            else
            {
                MessageBox.Show("Tạo mới thất bại", "Tạo thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableTxt();
            }
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPhoneNumber.Enabled = false;
            int index = e.RowIndex;
            if (index < 0 || index == _columnCount)
            {
                return;
            }
            txtPhoneNumber.Text = dtgCustomer.Rows[index].Cells[1].Value.ToString();
            txtNameCustomer.Text = dtgCustomer.Rows[index].Cells[2].Value.ToString();
            txtAddress.Text = dtgCustomer.Rows[index].Cells[3].Value.ToString();
            string cellGender = dtgCustomer.Rows[index].Cells[4].Value.ToString();
            Gender role = (Gender)Enum.Parse(typeof(Gender), cellGender);
            if (role == Gender.Male)
            {
                radMale.Checked = true;
                radFemale.Checked = false;
            }
            else
            {
                radMale.Checked = false;
                radFemale.Checked = true;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show($"Bạn có chắc chắn muốn cập nhật khách hàng {txtNameCustomer.Text} này", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                CustomerUpdateRequest request = new CustomerUpdateRequest()
                {
                    Name = txtNameCustomer.Text,
                    Address = txtAddress.Text,
                };
                if (radFemale.Checked)
                {
                    request.Gender = Gender.Female;
                }
                else
                {
                    request.Gender = Gender.Male;
                }
                var result = await managerCustomer.UpdateCustomer(txtPhoneNumber.Text, request);
                if (result)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công");
                    LoadGrid(null);
                    EnableTxt();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                    EnableTxt();
                }
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng {txtNameCustomer.Text} này", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                var result = await managerCustomer.DeleteCustomer(txtPhoneNumber.Text);
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadGrid(null);
                    EnableTxt();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    EnableTxt();
                }
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGrid(null);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGrid(null);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFind.Text))
            {
                
                LoadGrid(null);
            }
            else
            {
                LoadGrid(txtFind.Text);
                
            }
        }
    }
}
