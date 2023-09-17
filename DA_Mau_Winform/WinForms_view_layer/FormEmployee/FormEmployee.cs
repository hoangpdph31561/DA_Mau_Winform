using DA_mau_BussinessLayer.Catalog.Employee;
using DA_mau_Utilities.Common_Use;
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

namespace WinForms_view_layer
{
    public partial class FormEmployee : Form
    {
        ManageEmployeeService employeeService = new ManageEmployeeService();
        int employeeCount;
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadGrid(null);
        }
        private void ResetValue()
        {
            txtFind.PlaceholderText = "Nhập tên nhân viên cần tìm";
            txtEmail.Text = null;
            txtEmployeeName.Text = null;
            txtEmployeeAddress.Text = null;
            txtEmail.Enabled = false;
            txtEmployeeName.Enabled = false;
            txtEmployeeAddress.Enabled = false;
            radEmployee.Enabled = false;
            radManager.Enabled = false;
            radActive.Enabled = false;
            radInActive.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClose.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private async void LoadGrid(string? name)
        {
            int soThuTu = 1;
            dtgNhanVien.ColumnCount = 6;
            dtgNhanVien.Columns[0].Name = "Số thứ tự";
            dtgNhanVien.Columns[1].Name = "Email";
            dtgNhanVien.Columns[2].Name = "Tên nhân viên";
            dtgNhanVien.Columns[3].Name = "Địa chỉ";
            dtgNhanVien.Columns[4].Name = "Vai trò";
            dtgNhanVien.Columns[5].Name = "Tình trạng";
            dtgNhanVien.Rows.Clear();
            if (name == null)
            {
                var data = await employeeService.GetAll(null);
                employeeCount = data.Count;
                foreach (var item in data)
                {
                    dtgNhanVien.Rows.Add(soThuTu++, item.Email, item.Name, item.Address, Enum.GetName(typeof(Role), item.Role), Enum.GetName(typeof(Status), item.Status));

                }
            }
            else
            {
                var data = await employeeService.GetAll(name);
                employeeCount = data.Count;
                foreach (var item in data)
                {
                    dtgNhanVien.Rows.Add(soThuTu++, item.Email, item.Name, item.Address, Enum.GetName(typeof(Role), item.Role), Enum.GetName(typeof(Status), item.Status));

                }
            }

        }
        private void EnableBtnTxt()
        {
            txtEmail.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeeAddress.Text = string.Empty;
            txtEmail.Enabled = true;
            txtEmployeeName.Enabled = true;
            txtEmployeeAddress.Enabled = true;
            radEmployee.Enabled = true;
            radManager.Enabled = true;
            radActive.Enabled = true;
            radInActive.Enabled = true;
            radEmployee.Checked = true;
            radManager.Checked = false;
            radActive.Checked = true;
            radInActive.Checked = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableBtnTxt();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtEmployeeName.Text) && !string.IsNullOrEmpty(txtEmployeeAddress.Text))
            {
                string password = CommonUnitilyUse.RandomPassword(6, true);
                CreateNewEmployeeRequest request = new()
                {
                    Email = txtEmail.Text,
                    Address = txtEmployeeAddress.Text,
                    Name = txtEmployeeName.Text,
                    Password = password
                };
                if (radEmployee.Checked)
                {
                    request.Role = Role.Employee;
                }
                else
                {
                    request.Role = Role.Manager;
                }
                if (radActive.Checked)
                {
                    request.Status = Status.Active;
                }
                else
                {
                    request.Status = Status.Inactive;
                }
                var result = await employeeService.CreateEmployee(request);
                if (result)
                {
                    CommonUnitilyUse.SendMail(request.Email, password);
                    MessageBox.Show("Tạo thành công, password đã gửi tới email của chủ thể");
                    LoadGrid(null);
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Không thể tạo được nhân viên mới");
                }
            }
            else
            {
                MessageBox.Show("Trường dữ liệu phải được nhập đầy đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmail.Enabled = false;
            int index = e.RowIndex;
            if (index < 0 || index == employeeCount)
            {
                return;
            }
            txtEmail.Text = dtgNhanVien.Rows[index].Cells[1].Value.ToString();
            txtEmployeeName.Text = dtgNhanVien.Rows[index].Cells[2].Value.ToString();
            txtEmployeeAddress.Text = dtgNhanVien.Rows[index].Cells[3].Value.ToString();
            string cellRole = dtgNhanVien.Rows[index].Cells[4].Value.ToString();
            Role role = (Role)Enum.Parse(typeof(Role), cellRole);
            if (role == Role.Employee)
            {
                radEmployee.Checked = true;
                radManager.Checked = false;
            }
            else
            {
                radEmployee.Checked = false;
                radManager.Checked = true;
            }
            string cellStatus = dtgNhanVien.Rows[index].Cells[5].Value.ToString();
            Status status = (Status)Enum.Parse(typeof(Status), cellStatus);
            if (status == Status.Active)
            {
                radActive.Checked = true;
                radInActive.Checked = false;
            }
            else
            {
                radActive.Checked = false;
                radInActive.Checked = true;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show("Bạn có chắc muốn sửa thông tin nhân viên", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtEmployeeName.Text) && !string.IsNullOrEmpty(txtEmployeeAddress.Text) && reg == DialogResult.Yes)
            {
                UpdateRequest request = new UpdateRequest()
                {
                    Name = txtEmployeeName.Text,
                    Address = txtEmployeeAddress.Text,
                };
                if (radActive.Checked)
                {
                    request.Status = Status.Active;
                }
                else
                {
                    request.Status = Status.Inactive;
                }
                if (radEmployee.Checked)
                {
                    request.Role = Role.Employee;
                }
                else
                {
                    request.Role = Role.Manager;
                }
                var result = await employeeService.Updateemployee(request, txtEmail.Text);
                if (result)
                {
                    MessageBox.Show("Update thông tin nhân viên thành công");
                    LoadGrid(null);
                }
                else
                {
                    MessageBox.Show("Update thất bại", "Không update được", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show("Bạn có chắc muốn xóa không", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                var result = await employeeService.DeleteEmployee(txtEmail.Text);
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadGrid(null);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                LoadGrid(null);
            }
            else
            {
                LoadGrid(txtFind.Text);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
