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
using WinForms_view_layer.FormCustomer;

namespace WinForms_view_layer.MailLayout
{
    public partial class FormMainScreen : Form
    {
        private FormCustomer.FormCustomer frmCustomer;
        private FormDangNhap dn;
        private FormEmployee frmEmployee;
        private FormProduct frmProduct;
        private FormChangePassword.FormChangePassword changePassword;
        public static int _session = 0;
        public static int _profile = 0;
        public static string _mail;
        public static Role _role;
        public static int _employeeId;
        public FormMainScreen()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }


        public void FormMainScreen_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (_profile == 1)
            {
                danhMụcToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                _profile = 0;
            }
        }
        private void ResetValue()
        {
            if (_session == 1)
            {
                lblTenNguoiDung.Text = "Hello " + _mail;
                danhMụcToolStripMenuItem.Visible = true;
                nhânViênToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                hồSơNhânViênToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Visible = false;
                if (_role == Role.Employee)
                {
                    VaiTroNV();
                }
            }
            else
            {
                lblTenNguoiDung.Text = string.Empty;
                nhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = false;
                hồSơNhânViênToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Visible = true;
            }
        }
        private void FormDangNhap_Close(object sender, EventArgs e)
        {
            this.Refresh();
            FormMainScreen_Load(sender, e);
        }
        private void FormChangePassword_Close(object sender, EventArgs e)
        {
            this.Refresh();
            FormMainScreen_Load(sender, e);
        }
        private void VaiTroNV()
        {
            nhânViênToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new FormDangNhap();
            if (!CheckExistForm("FormDangNhap"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(FormDangNhap_Close);
            }
            else
            {
                ActiveChildForm("FormDangNhap");
            }
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword = new FormChangePassword.FormChangePassword();
            if (!CheckExistForm("FormChangePassword"))
            {
                changePassword.MdiParent = this;
                changePassword.Show();
                changePassword.FormClosed += new FormClosedEventHandler(FormChangePassword_Close);
            }
            else
            {
                ActiveChildForm("FormChangePassword");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show("Bạn có thực sự muốn thoát không", "Confirm thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                _session = 0;
                _mail = string.Empty;
                FormChangePassword_Close(sender, e);
            }

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee = new FormEmployee();
            if (!CheckExistForm("FormEmployee"))
            {
                frmEmployee.MdiParent = this;
                frmEmployee.Show();
                frmEmployee.FormClosed += new FormClosedEventHandler(FormChangePassword_Close);
            }
            else
            {
                ActiveChildForm("FormEmployee");
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer = new FormCustomer.FormCustomer();
            if (!CheckExistForm("FormCustomer"))
            {
                frmCustomer.MdiParent = this;
                frmCustomer.Show();
                frmCustomer.FormClosed += new FormClosedEventHandler(FormChangePassword_Close);
            }
            else
            {
                ActiveChildForm("FormCustomer");
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct = new FormProduct();
            if (!CheckExistForm("FormProduct"))
            {
                frmProduct.MdiParent = this;
                frmProduct.Show();
                frmProduct.FormClosed += new FormClosedEventHandler(FormChangePassword_Close);
            }
            else
            {
                ActiveChildForm("FormProduct");
            }
        }
    }
}
