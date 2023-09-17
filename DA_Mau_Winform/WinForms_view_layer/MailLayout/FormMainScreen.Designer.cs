namespace WinForms_view_layer.MailLayout
{
    partial class FormMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            hồSơNhânViênToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmNhậpKhoToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmTồnKhoToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            lblTenNguoiDung = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, thốngKêToolStripMenuItem, hướngDẫnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1258, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, hồSơNhânViênToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.ShortcutKeyDisplayString = "";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            đăngNhậpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            đăngNhậpToolStripMenuItem.Size = new Size(218, 26);
            đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            đăngXuấtToolStripMenuItem.Size = new Size(218, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // hồSơNhânViênToolStripMenuItem
            // 
            hồSơNhânViênToolStripMenuItem.Name = "hồSơNhânViênToolStripMenuItem";
            hồSơNhânViênToolStripMenuItem.Size = new Size(218, 26);
            hồSơNhânViênToolStripMenuItem.Text = "Hồ sơ nhân viên";
            hồSơNhânViênToolStripMenuItem.Click += hồSơNhânViênToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            thoátToolStripMenuItem.Size = new Size(218, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sảnPhẩmToolStripMenuItem, nhânViênToolStripMenuItem, kháchHàngToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(224, 26);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(224, 26);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sảnPhẩmNhậpKhoToolStripMenuItem, sảnPhẩmTồnKhoToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(84, 24);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // sảnPhẩmNhậpKhoToolStripMenuItem
            // 
            sảnPhẩmNhậpKhoToolStripMenuItem.Name = "sảnPhẩmNhậpKhoToolStripMenuItem";
            sảnPhẩmNhậpKhoToolStripMenuItem.Size = new Size(223, 26);
            sảnPhẩmNhậpKhoToolStripMenuItem.Text = "Sản phẩm nhập kho";
            // 
            // sảnPhẩmTồnKhoToolStripMenuItem
            // 
            sảnPhẩmTồnKhoToolStripMenuItem.Name = "sảnPhẩmTồnKhoToolStripMenuItem";
            sảnPhẩmTồnKhoToolStripMenuItem.Size = new Size(223, 26);
            sảnPhẩmTồnKhoToolStripMenuItem.Text = "Sản phẩm tồn kho";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hướngDẫnSửDụngToolStripMenuItem, giớiThiệuPhầnMềmToolStripMenuItem });
            hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            hướngDẫnToolStripMenuItem.Size = new Size(98, 24);
            hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(231, 26);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // giớiThiệuPhầnMềmToolStripMenuItem
            // 
            giớiThiệuPhầnMềmToolStripMenuItem.Name = "giớiThiệuPhầnMềmToolStripMenuItem";
            giớiThiệuPhầnMềmToolStripMenuItem.Size = new Size(231, 26);
            giớiThiệuPhầnMềmToolStripMenuItem.Text = "Giới thiệu phần mềm";
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.Dock = DockStyle.Top;
            lblTenNguoiDung.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNguoiDung.Location = new Point(0, 28);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(0, 35);
            lblTenNguoiDung.TabIndex = 1;
            // 
            // FormMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 768);
            Controls.Add(lblTenNguoiDung);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMainScreen";
            Load += FormMainScreen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmNhậpKhoToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmTồnKhoToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuPhầnMềmToolStripMenuItem;
        private Label lblTenNguoiDung;
        private ToolStripMenuItem hồSơNhânViênToolStripMenuItem;
    }
}