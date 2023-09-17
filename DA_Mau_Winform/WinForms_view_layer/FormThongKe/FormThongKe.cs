using DA_mau_BussinessLayer.Catalog.Employee;
using DA_mau_BussinessLayer.Catalog.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_view_layer.FormThongKe
{
    public partial class FormThongKe : Form
    {
        ManageProductService manageProductService = new ManageProductService();
        ManageEmployeeService ManageEmployeeService = new ManageEmployeeService();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private async void btnTonKho_Click(object sender, EventArgs e)
        {
            dgvThongKe.Columns.Clear();
            int soThuTu = 1;
            dgvThongKe.ColumnCount = 3;
            dgvThongKe.Columns[0].Name = "Số thứ tự";
            dgvThongKe.Columns[1].Name = "Tên hàng";
            dgvThongKe.Columns[2].Name = "Số lượng tồn";
            dgvThongKe.Rows.Clear();
            var data = await manageProductService.CheckProductInventory();
            foreach (var item in data)
            {
                dgvThongKe.Rows.Add(soThuTu++, item.ProductName, item.Quantity);
            }
        }

        private async void btnNhapKho_Click(object sender, EventArgs e)
        {
            dgvThongKe.Columns.Clear();
            int soThuTu = 1;
            dgvThongKe.ColumnCount = 4;
            dgvThongKe.Columns[0].Name = "Số thứ tự";
            dgvThongKe.Columns[1].Name = "Mã nhân viên";
            dgvThongKe.Columns[2].Name = "Tên nhân viên";
            dgvThongKe.Columns[3].Name = "Số lượng sản phẩm nhập";
            dgvThongKe.Rows.Clear();
            var data = await ManageEmployeeService.GetProductInput();
            foreach (var item in data)
            {
                dgvThongKe.Rows.Add(soThuTu++, item.EmployeeId, item.EmployeeName,item.ProductCount);
            }
        }
    }
}
