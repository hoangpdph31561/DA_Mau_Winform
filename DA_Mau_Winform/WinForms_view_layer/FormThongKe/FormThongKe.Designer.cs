namespace WinForms_view_layer.FormThongKe
{
    partial class FormThongKe
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
            dgvThongKe = new DataGridView();
            btnNhapKho = new Button();
            btnTonKho = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // dgvThongKe
            // 
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvThongKe.BorderStyle = BorderStyle.Fixed3D;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Enabled = false;
            dgvThongKe.Location = new Point(48, 70);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.RowTemplate.Height = 29;
            dgvThongKe.Size = new Size(773, 188);
            dgvThongKe.TabIndex = 1;
            // 
            // btnNhapKho
            // 
            btnNhapKho.Location = new Point(12, 12);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Size = new Size(163, 29);
            btnNhapKho.TabIndex = 2;
            btnNhapKho.Text = "Sản phẩm nhập kho";
            btnNhapKho.UseVisualStyleBackColor = true;
            btnNhapKho.Click += btnNhapKho_Click;
            // 
            // btnTonKho
            // 
            btnTonKho.Location = new Point(181, 12);
            btnTonKho.Name = "btnTonKho";
            btnTonKho.Size = new Size(94, 29);
            btnTonKho.TabIndex = 3;
            btnTonKho.Text = "Tồn kho";
            btnTonKho.UseVisualStyleBackColor = true;
            btnTonKho.Click += btnTonKho_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 286);
            Controls.Add(btnTonKho);
            Controls.Add(btnNhapKho);
            Controls.Add(dgvThongKe);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvThongKe;
        private Button btnNhapKho;
        private Button btnTonKho;
    }
}