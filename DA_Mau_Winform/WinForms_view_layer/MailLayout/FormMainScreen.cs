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

namespace WinForms_view_layer.MailLayout
{
    public partial class FormMainScreen : Form
    {
        private FormDangNhap dn;
        public static int _session = 0;
        public static int _profile = 0;
        public static string _mail;
        public static Role _role;
        public FormMainScreen()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }


        public void FormMainScreen_Load(object sender, EventArgs e)
        {
            ResetValue();
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
    }
}
