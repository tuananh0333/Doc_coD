namespace Project_LTUD_LeTuanAnh
{
    partial class frmNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_addSV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_addSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_ttTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_quanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_traSach = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lstSach = new System.Windows.Forms.ListView();
            this.lstSinhVien = new System.Windows.Forms.ListView();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.btnTimSV = new System.Windows.Forms.Button();
            this.txtTimSV = new System.Windows.Forms.TextBox();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTimSach = new System.Windows.Forms.ComboBox();
            this.cboTimSV = new System.Windows.Forms.ComboBox();
            this.btnThongTinSach = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào,";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1349, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_addSV,
            this.TSMItem_addSach});
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // TSMItem_addSV
            // 
            this.TSMItem_addSV.Name = "TSMItem_addSV";
            this.TSMItem_addSV.Size = new System.Drawing.Size(146, 22);
            this.TSMItem_addSV.Text = "Sinh viên mới";
            this.TSMItem_addSV.Click += new System.EventHandler(this.TSMItem_addSV_Click);
            // 
            // TSMItem_addSach
            // 
            this.TSMItem_addSach.Name = "TSMItem_addSach";
            this.TSMItem_addSach.Size = new System.Drawing.Size(146, 22);
            this.TSMItem_addSach.Text = "Sách mới";
            this.TSMItem_addSach.Click += new System.EventHandler(this.TSMItem_addSach_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_ttTaiKhoan,
            this.TSMItem_DangXuat});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // TSMItem_ttTaiKhoan
            // 
            this.TSMItem_ttTaiKhoan.Name = "TSMItem_ttTaiKhoan";
            this.TSMItem_ttTaiKhoan.Size = new System.Drawing.Size(178, 22);
            this.TSMItem_ttTaiKhoan.Text = "Thông tin tài khoản";
            this.TSMItem_ttTaiKhoan.Click += new System.EventHandler(this.TSMItem_ttTaiKhoan_Click);
            // 
            // TSMItem_DangXuat
            // 
            this.TSMItem_DangXuat.Name = "TSMItem_DangXuat";
            this.TSMItem_DangXuat.Size = new System.Drawing.Size(178, 22);
            this.TSMItem_DangXuat.Text = "Đăng xuất";
            this.TSMItem_DangXuat.Click += new System.EventHandler(this.TSMItem_DangXuat_Click);
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.TSMI_quanLy,
            this.TSMI_traSach});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.refreshToolStripMenuItem.Text = "Làm mới";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // TSMI_quanLy
            // 
            this.TSMI_quanLy.Name = "TSMI_quanLy";
            this.TSMI_quanLy.Size = new System.Drawing.Size(166, 22);
            this.TSMI_quanLy.Text = "Quản lý";
            this.TSMI_quanLy.Click += new System.EventHandler(this.TSMI_quanLy_Click);
            // 
            // TSMI_traSach
            // 
            this.TSMI_traSach.Name = "TSMI_traSach";
            this.TSMI_traSach.Size = new System.Drawing.Size(166, 22);
            this.TSMI_traSach.Text = "Sinh viên trả sách";
            this.TSMI_traSach.Click += new System.EventHandler(this.TSMI_traSach_Click);
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(646, 40);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(70, 18);
            this.lblTenNhanVien.TabIndex = 2;
            this.lblTenNhanVien.Text = "Tuấn Anh";
            // 
            // lstSach
            // 
            this.lstSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstSach.Location = new System.Drawing.Point(12, 99);
            this.lstSach.Name = "lstSach";
            this.lstSach.Size = new System.Drawing.Size(580, 529);
            this.lstSach.TabIndex = 3;
            this.lstSach.UseCompatibleStateImageBehavior = false;
            this.lstSach.SelectedIndexChanged += new System.EventHandler(this.lstSach_SelectedIndexChanged);
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSinhVien.Location = new System.Drawing.Point(712, 100);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(624, 529);
            this.lstSinhVien.TabIndex = 4;
            this.lstSinhVien.UseCompatibleStateImageBehavior = false;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(12, 650);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSach.TabIndex = 6;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(377, 72);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(134, 20);
            this.txtTimSach.TabIndex = 7;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(517, 70);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(75, 23);
            this.btnTimSach.TabIndex = 8;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // btnTimSV
            // 
            this.btnTimSV.Location = new System.Drawing.Point(1229, 71);
            this.btnTimSV.Name = "btnTimSV";
            this.btnTimSV.Size = new System.Drawing.Size(107, 23);
            this.btnTimSV.TabIndex = 10;
            this.btnTimSV.Text = "Tìm Sinh Viên";
            this.btnTimSV.UseVisualStyleBackColor = true;
            this.btnTimSV.Click += new System.EventHandler(this.btnTimSV_Click);
            // 
            // txtTimSV
            // 
            this.txtTimSV.Location = new System.Drawing.Point(1089, 73);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.Size = new System.Drawing.Size(134, 20);
            this.txtTimSV.TabIndex = 9;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(1261, 650);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSV.TabIndex = 12;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(642, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 528);
            this.panel1.TabIndex = 13;
            // 
            // cboTimSach
            // 
            this.cboTimSach.FormattingEnabled = true;
            this.cboTimSach.Location = new System.Drawing.Point(250, 72);
            this.cboTimSach.Name = "cboTimSach";
            this.cboTimSach.Size = new System.Drawing.Size(121, 21);
            this.cboTimSach.TabIndex = 14;
            // 
            // cboTimSV
            // 
            this.cboTimSV.FormattingEnabled = true;
            this.cboTimSV.Location = new System.Drawing.Point(962, 73);
            this.cboTimSV.Name = "cboTimSV";
            this.cboTimSV.Size = new System.Drawing.Size(121, 21);
            this.cboTimSV.TabIndex = 15;
            // 
            // btnThongTinSach
            // 
            this.btnThongTinSach.Location = new System.Drawing.Point(220, 650);
            this.btnThongTinSach.Name = "btnThongTinSach";
            this.btnThongTinSach.Size = new System.Drawing.Size(151, 23);
            this.btnThongTinSach.TabIndex = 16;
            this.btnThongTinSach.Text = "Sửa Thông Tin Sách";
            this.btnThongTinSach.UseVisualStyleBackColor = true;
            this.btnThongTinSach.Click += new System.EventHandler(this.btnThongTinSach_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 685);
            this.Controls.Add(this.btnThongTinSach);
            this.Controls.Add(this.cboTimSV);
            this.Controls.Add(this.cboTimSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnTimSV);
            this.Controls.Add(this.txtTimSV);
            this.Controls.Add(this.btnTimSach);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.lstSach);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doc@coD";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_addSV;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_addSach;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.ListView lstSach;
        private System.Windows.Forms.ListView lstSinhVien;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.Button btnTimSV;
        private System.Windows.Forms.TextBox txtTimSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTimSach;
        private System.Windows.Forms.ComboBox cboTimSV;
        private System.Windows.Forms.Button btnThongTinSach;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_ttTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_quanLy;
        private System.Windows.Forms.ToolStripMenuItem TSMI_traSach;
    }
}