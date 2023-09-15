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
        public FormMainScreen()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void FormMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new FormDangNhap();
            if (!CheckExistForm("FormDangNhap"))
            {
                dn.MdiParent = this;
                dn.Show();
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
