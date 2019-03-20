namespace Project_LTUD_LeTuanAnh
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_ttTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_ttDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstSach = new System.Windows.Forms.ListView();
            this.lblTenSinhVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTimSach = new System.Windows.Forms.ComboBox();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ttxtTongTinSach = new System.Windows.Forms.RichTextBox();
            this.lblGiaBia = new System.Windows.Forms.Label();
            this.lblTensach = new System.Windows.Forms.Label();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblSoTrang = new System.Windows.Forms.Label();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.btnDatMuon = new System.Windows.Forms.Button();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.làmMớiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_ttTaiKhoan,
            this.TSMItem_ttDangXuat});
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
            // TSMItem_ttDangXuat
            // 
            this.TSMItem_ttDangXuat.Name = "TSMItem_ttDangXuat";
            this.TSMItem_ttDangXuat.Size = new System.Drawing.Size(178, 22);
            this.TSMItem_ttDangXuat.Text = "đăng xuất";
            this.TSMItem_ttDangXuat.Click += new System.EventHandler(this.TSMItem_ttDangXuat_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.làmMớiToolStripMenuItem.Text = "làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // lstSach
            // 
            this.lstSach.Location = new System.Drawing.Point(12, 132);
            this.lstSach.Name = "lstSach";
            this.lstSach.Size = new System.Drawing.Size(828, 531);
            this.lstSach.TabIndex = 1;
            this.lstSach.UseCompatibleStateImageBehavior = false;
            this.lstSach.SelectedIndexChanged += new System.EventHandler(this.lstSach_SelectedIndexChanged);
            // 
            // lblTenSinhVien
            // 
            this.lblTenSinhVien.AutoSize = true;
            this.lblTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSinhVien.Location = new System.Drawing.Point(712, 34);
            this.lblTenSinhVien.Name = "lblTenSinhVien";
            this.lblTenSinhVien.Size = new System.Drawing.Size(70, 18);
            this.lblTenSinhVien.TabIndex = 5;
            this.lblTenSinhVien.Text = "Tuấn Anh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xin chào,";
            // 
            // cboTimSach
            // 
            this.cboTimSach.FormattingEnabled = true;
            this.cboTimSach.Location = new System.Drawing.Point(12, 96);
            this.cboTimSach.Name = "cboTimSach";
            this.cboTimSach.Size = new System.Drawing.Size(121, 21);
            this.cboTimSach.TabIndex = 17;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(279, 94);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(75, 23);
            this.btnTimSach.TabIndex = 16;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(139, 96);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(134, 20);
            this.txtTimSach.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(912, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(928, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tác giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(922, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thể loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(870, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Năm Xuất Bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(916, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số trang:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(928, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Giá bìa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(866, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nội dung chính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(953, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 57);
            this.label9.TabIndex = 25;
            this.label9.Text = "Thông tin sách";
            // 
            // ttxtTongTinSach
            // 
            this.ttxtTongTinSach.Enabled = false;
            this.ttxtTongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttxtTongTinSach.Location = new System.Drawing.Point(1005, 367);
            this.ttxtTongTinSach.Name = "ttxtTongTinSach";
            this.ttxtTongTinSach.Size = new System.Drawing.Size(302, 232);
            this.ttxtTongTinSach.TabIndex = 26;
            this.ttxtTongTinSach.Text = resources.GetString("ttxtTongTinSach.Text");
            // 
            // lblGiaBia
            // 
            this.lblGiaBia.AutoSize = true;
            this.lblGiaBia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBia.Location = new System.Drawing.Point(1005, 337);
            this.lblGiaBia.Name = "lblGiaBia";
            this.lblGiaBia.Size = new System.Drawing.Size(84, 16);
            this.lblGiaBia.TabIndex = 27;
            this.lblGiaBia.Text = "105.000 VNĐ";
            // 
            // lblTensach
            // 
            this.lblTensach.AutoSize = true;
            this.lblTensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensach.Location = new System.Drawing.Point(1005, 121);
            this.lblTensach.Name = "lblTensach";
            this.lblTensach.Size = new System.Drawing.Size(177, 25);
            this.lblTensach.TabIndex = 28;
            this.lblTensach.Text = "Không Gia Đình";
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTacGia.Location = new System.Drawing.Point(1006, 158);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(100, 20);
            this.lblTenTacGia.TabIndex = 29;
            this.lblTenTacGia.Text = "Hector malot";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(1005, 195);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(73, 16);
            this.lblLoai.TabIndex = 30;
            this.lblLoai.Text = "Tiểu thuyết";
            // 
            // lblSoTrang
            // 
            this.lblSoTrang.AutoSize = true;
            this.lblSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTrang.Location = new System.Drawing.Point(1005, 228);
            this.lblSoTrang.Name = "lblSoTrang";
            this.lblSoTrang.Size = new System.Drawing.Size(39, 16);
            this.lblSoTrang.TabIndex = 31;
            this.lblSoTrang.Text = "270 tr";
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXuatBan.Location = new System.Drawing.Point(1005, 299);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(36, 16);
            this.lblNamXuatBan.TabIndex = 32;
            this.lblNamXuatBan.Text = "2006";
            // 
            // btnDatMuon
            // 
            this.btnDatMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatMuon.Location = new System.Drawing.Point(1005, 626);
            this.btnDatMuon.Name = "btnDatMuon";
            this.btnDatMuon.Size = new System.Drawing.Size(177, 37);
            this.btnDatMuon.TabIndex = 33;
            this.btnDatMuon.Text = "Đặt mượn";
            this.btnDatMuon.UseVisualStyleBackColor = true;
            this.btnDatMuon.Click += new System.EventHandler(this.btnDatMuon_Click);
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaXuatBan.Location = new System.Drawing.Point(1005, 266);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(60, 16);
            this.lblNhaXuatBan.TabIndex = 35;
            this.lblNhaXuatBan.Text = "Văn Học";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(874, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Nhà Xuất Bản:";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 682);
            this.Controls.Add(this.lblNhaXuatBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDatMuon);
            this.Controls.Add(this.lblNamXuatBan);
            this.Controls.Add(this.lblSoTrang);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblTenTacGia);
            this.Controls.Add(this.lblTensach);
            this.Controls.Add(this.lblGiaBia);
            this.Controls.Add(this.ttxtTongTinSach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTimSach);
            this.Controls.Add(this.btnTimSach);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.lblTenSinhVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSach);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doc@coD";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_ttTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_ttDangXuat;
        private System.Windows.Forms.ListView lstSach;
        private System.Windows.Forms.Label lblTenSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTimSach;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox ttxtTongTinSach;
        private System.Windows.Forms.Label lblGiaBia;
        private System.Windows.Forms.Label lblTensach;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSoTrang;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.Button btnDatMuon;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
    }
}