using DA_mau_BussinessLayer.Catalog.Product;
using DA_mau_Utilities.Common_Use;
using DA_mau_Utilities.ProductRequest;
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
    public partial class FormProduct : Form
    {
        private readonly ManageProductService manageProduct = new ManageProductService();
        private int _productCount;
        private string saveDirectory = @"E:\FPT politechnic\DA_Mau\Code_DA_Mau_Winform\DA_Mau_Winform\WinForms_view_layer\Resources\";
        private string fileSavePath = string.Empty;
        private string fileAddress = string.Empty;
        private string currentImage = string.Empty;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadGrid(null);
        }
        private void EnableBtnTxt()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            txtProductInputPrice.Text = string.Empty;
            txtProductSellPrice.Text = string.Empty;
            txtProductNote.Text = string.Empty;
            txtProductId.Enabled = false;
            txtProductName.Enabled = true;
            txtProductQuantity.Enabled = true;
            txtProductInputPrice.Enabled = true;
            txtProductSellPrice.Enabled = true;
            txtProductNote.Enabled = true;
            btnOpenImage.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            fileSavePath = string.Empty;
            fileAddress = string.Empty;
            pictureBox1.Image = null;
        }
        private void ResetValue()
        {
            txtProductId.Text = null;
            txtProductName.Text = null;
            txtProductQuantity.Text = null;
            txtProductInputPrice.Text = null;
            txtProductSellPrice.Text = null;
            txtProductNote.Text = null;
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtProductQuantity.Enabled = false;
            txtProductInputPrice.Enabled = false;
            txtProductSellPrice.Enabled = false;
            txtProductNote.Enabled = false;
            btnOpenImage.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            txtFind.PlaceholderText = "Nhập tên sản phẩm";
            fileSavePath = string.Empty;
            fileAddress = string.Empty;
            pictureBox1.Image = null;
        }
        private async void LoadGrid(string? productName)
        {
            int soThuTu = 1;
            dgvProduct.ColumnCount = 9;
            dgvProduct.Columns[0].Name = "Số thứ tự";
            dgvProduct.Columns[1].Name = "Mã sản phẩm";
            dgvProduct.Columns[2].Name = "Tên sản phẩm";
            dgvProduct.Columns[3].Name = "Số lượng";
            dgvProduct.Columns[4].Name = "Đơn giá nhập";
            dgvProduct.Columns[5].Name = "Đơn giá bán";
            dgvProduct.Columns[6].Name = "Hình ảnh";
            dgvProduct.Columns[7].Name = "Ghi chú";
            dgvProduct.Columns[8].Name = "Người nhập";
            dgvProduct.Rows.Clear();
            if (string.IsNullOrWhiteSpace(productName))
            {
                var data = await manageProduct.GetAll(null);
                _productCount = data.Count;
                foreach (var item in data)
                {
                    dgvProduct.Rows.Add(soThuTu++, item.ProductId, item.ProductName, item.ProductQuantity, item.InputPrice, item.SellPrice, item.Images, item.Note, item.EmployeeName);
                }
            }
            else
            {
                var data = await manageProduct.GetAll(productName);
                _productCount = data.Count;
                foreach (var item in data)
                {
                    dgvProduct.Rows.Add(soThuTu++, item.ProductId, item.ProductName, item.ProductQuantity, item.InputPrice, item.SellPrice, item.Images, item.Note, item.EmployeeName);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableBtnTxt();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileAddress = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(fileAddress);
                string fileName = Path.GetFileName(openFileDialog.FileName);
                fileSavePath = saveDirectory + fileName;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckRegex())
            {
                ProductCreateRequest request = new()
                {
                    EmployeeId = FormMainScreen._employeeId,
                    Name = txtProductName.Text,
                    Quantity = Convert.ToInt32(txtProductQuantity.Text),
                    InputPrice = Convert.ToDecimal(txtProductInputPrice.Text),
                    SellPrice = Convert.ToDecimal(txtProductSellPrice.Text),
                    ImagePath = fileSavePath,
                    Note = txtProductNote.Text,
                };
                var result = await manageProduct.CreateNewProduct(request);
                if (result)
                {
                    MessageBox.Show("Thêm ảnh thành công");
                    File.Copy(fileAddress, fileSavePath, true);

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            
            LoadGrid(null);
            EnableBtnTxt();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _productCount)
            {
                return;
            }
            txtProductId.Text = dgvProduct.Rows[index].Cells[1].Value.ToString();
            txtProductName.Text = dgvProduct.Rows[index].Cells[2].Value.ToString();
            txtProductQuantity.Text = dgvProduct.Rows[index].Cells[3].Value.ToString();
            txtProductInputPrice.Text = dgvProduct.Rows[index].Cells[4].Value.ToString();
            txtProductSellPrice.Text = dgvProduct.Rows[index].Cells[5].Value.ToString();
            fileSavePath = dgvProduct.Rows[index].Cells[6].Value.ToString();
            currentImage = fileSavePath;
            txtProductNote.Text = dgvProduct.Rows[index].Cells[7].Value.ToString();
            pictureBox1.Image = Image.FromFile(fileSavePath);

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show($"Bạn có muốn cập nhật lại sản phẩm {txtProductName.Text} chứ", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                if (CheckRegex())
                {
                    ProductUpdateRequest request = new()
                    {
                        Name = txtProductName.Text,
                        Quantity = Convert.ToInt32(txtProductQuantity.Text),
                        InputPrice = Convert.ToDecimal(txtProductInputPrice.Text),
                        SellPrice = Convert.ToDecimal(txtProductSellPrice.Text),
                        Note = txtProductNote.Text,
                        PhotoPath = fileSavePath
                    };
                    if (currentImage != fileSavePath)
                    {
                        File.Copy(fileAddress, fileSavePath, true);
                    }
                    var result = await manageProduct.UpdateProduct(Convert.ToInt32(txtProductId.Text), request);
                    if (result)
                    {
                        MessageBox.Show("Cập nhập lại sản phẩm thành công");

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
               
                LoadGrid(null);
                EnableBtnTxt();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show($"Bạn có muốn xóa sản phẩm {txtProductName.Text} chứ", "Xác nhận xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                var result = await manageProduct.DeleteProduct(Convert.ToInt32(txtProductId.Text));
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }

                LoadGrid(null);
                EnableBtnTxt();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                LoadGrid(null);
            }
            else
            {
                LoadGrid(txtProductName.Text);
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            LoadGrid(null);
            ResetValue();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadGrid(null);
            ResetValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private bool CheckRegex()
        {
            errorProvider1.SetError(txtProductName, "");
            errorProvider1.SetError(txtProductQuantity, "");
            errorProvider1.SetError(txtProductSellPrice, "");
            errorProvider1.SetError(txtProductInputPrice, "");
            errorProvider1.SetError(pictureBox1, "");
            errorProvider1.SetError(txtProductNote, "");
            if(string.IsNullOrWhiteSpace(txtProductName.Text) )
            {
                errorProvider1.SetError(txtProductName, "Chưa nhập tên hàng");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtProductQuantity.Text) )
            {
                errorProvider1.SetError(txtProductQuantity, "Chưa nhập số lượng sản phẩm");
                return false;
            }
            else if (!CommonUnitilyUse.RegexNumberInterger(txtProductQuantity.Text))
            {
                errorProvider1.SetError(txtProductQuantity, "Nhập số nguyên");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtProductInputPrice.Text) )
            {
                errorProvider1.SetError(txtProductInputPrice, "Chưa nhập giá nhập");
                return false;
            }
            else if (!CommonUnitilyUse.RegexNumberDecimal(txtProductInputPrice.Text))
            {
                errorProvider1.SetError(txtProductInputPrice, "Nhập số thực");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductSellPrice.Text))
            {
                errorProvider1.SetError(txtProductSellPrice, "Chưa nhập giá bán");
                return false;
            }
            else if (!CommonUnitilyUse.RegexNumberDecimal(txtProductSellPrice.Text))
            {
                errorProvider1.SetError(txtProductSellPrice, "Nhập số thực");
                return false;
            }
            if(pictureBox1.Image == null)
            {
                errorProvider1.SetError(pictureBox1, "Chưa có ảnh");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtProductNote.Text))
            {
                errorProvider1.SetError(txtProductNote, "Chưa nhập ghi chú");
                return false;
            }
            return true;
        }
    }
}
