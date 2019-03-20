namespace Project_LTUD_LeTuanAnh
{
    partial class frmThongTinSinhVien
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
            this.lblKhongKhop = new System.Windows.Forms.Label();
            this.lblTrungKhop = new System.Windows.Forms.Label();
            this.lblUserNameAvaiable = new System.Windows.Forms.Label();
            this.lblUserNameNotValid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoSachMuon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDoiTenDangNhap = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblMatKhauSai = new System.Windows.Forms.Label();
            this.lblMatKhauDung = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKhongKhop
            // 
            this.lblKhongKhop.AutoSize = true;
            this.lblKhongKhop.ForeColor = System.Drawing.Color.Red;
            this.lblKhongKhop.Location = new System.Drawing.Point(184, 528);
            this.lblKhongKhop.Name = "lblKhongKhop";
            this.lblKhongKhop.Size = new System.Drawing.Size(59, 13);
            this.lblKhongKhop.TabIndex = 18;
            this.lblKhongKhop.Text = "Chưa khớp";
            // 
            // lblTrungKhop
            // 
            this.lblTrungKhop.AutoSize = true;
            this.lblTrungKhop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTrungKhop.Location = new System.Drawing.Point(181, 528);
            this.lblTrungKhop.Name = "lblTrungKhop";
            this.lblTrungKhop.Size = new System.Drawing.Size(58, 13);
            this.lblTrungKhop.TabIndex = 17;
            this.lblTrungKhop.Text = "trùng khớp";
            // 
            // lblUserNameAvaiable
            // 
            this.lblUserNameAvaiable.AutoSize = true;
            this.lblUserNameAvaiable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUserNameAvaiable.Location = new System.Drawing.Point(184, 426);
            this.lblUserNameAvaiable.Name = "lblUserNameAvaiable";
            this.lblUserNameAvaiable.Size = new System.Drawing.Size(116, 13);
            this.lblUserNameAvaiable.TabIndex = 16;
            this.lblUserNameAvaiable.Text = "có thể sử dụng tên này";
            // 
            // lblUserNameNotValid
            // 
            this.lblUserNameNotValid.AutoSize = true;
            this.lblUserNameNotValid.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameNotValid.Location = new System.Drawing.Point(183, 426);
            this.lblUserNameNotValid.Name = "lblUserNameNotValid";
            this.lblUserNameNotValid.Size = new System.Drawing.Size(99, 13);
            this.lblUserNameNotValid.TabIndex = 15;
            this.lblUserNameNotValid.Text = "tài khoản đã tồn tại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN BẠN ĐỌC";
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifyPassword.Location = new System.Drawing.Point(183, 499);
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.PasswordChar = '✱';
            this.txtVerifyPassword.Size = new System.Drawing.Size(201, 26);
            this.txtVerifyPassword.TabIndex = 13;
            this.txtVerifyPassword.TextChanged += new System.EventHandler(this.txtVerifyPassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Xác nhận mật khẩu:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(183, 460);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '✱';
            this.txtNewPassword.Size = new System.Drawing.Size(201, 26);
            this.txtNewPassword.TabIndex = 11;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật khẩu mới:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(182, 395);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 26);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtSoSachMuon);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnDoiTenDangNhap);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.lblMatKhauSai);
            this.groupBox1.Controls.Add(this.lblMatKhauDung);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblKhongKhop);
            this.groupBox1.Controls.Add(this.lblTrungKhop);
            this.groupBox1.Controls.Add(this.lblUserNameAvaiable);
            this.groupBox1.Controls.Add(this.lblUserNameNotValid);
            this.groupBox1.Controls.Add(this.txtVerifyPassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dpkNgaySinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenSinhVien);
            this.groupBox1.Controls.Add(this.txtMaSinhVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(67, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 553);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(218, 272);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 38);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtSoSachMuon
            // 
            this.txtSoSachMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSachMuon.Location = new System.Drawing.Point(184, 221);
            this.txtSoSachMuon.Name = "txtSoSachMuon";
            this.txtSoSachMuon.Size = new System.Drawing.Size(98, 26);
            this.txtSoSachMuon.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Số sách đã mượn: ";
            // 
            // btnDoiTenDangNhap
            // 
            this.btnDoiTenDangNhap.Location = new System.Drawing.Point(389, 395);
            this.btnDoiTenDangNhap.Name = "btnDoiTenDangNhap";
            this.btnDoiTenDangNhap.Size = new System.Drawing.Size(105, 23);
            this.btnDoiTenDangNhap.TabIndex = 24;
            this.btnDoiTenDangNhap.Text = "Đổi tên đăng nhập";
            this.btnDoiTenDangNhap.UseVisualStyleBackColor = true;
            this.btnDoiTenDangNhap.Click += new System.EventHandler(this.btnDoiTenDangNhap_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(391, 501);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(105, 23);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblMatKhauSai
            // 
            this.lblMatKhauSai.AutoSize = true;
            this.lblMatKhauSai.ForeColor = System.Drawing.Color.Red;
            this.lblMatKhauSai.Location = new System.Drawing.Point(183, 368);
            this.lblMatKhauSai.Name = "lblMatKhauSai";
            this.lblMatKhauSai.Size = new System.Drawing.Size(69, 13);
            this.lblMatKhauSai.TabIndex = 22;
            this.lblMatKhauSai.Text = "Sai mật khẩu";
            // 
            // lblMatKhauDung
            // 
            this.lblMatKhauDung.AutoSize = true;
            this.lblMatKhauDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMatKhauDung.Location = new System.Drawing.Point(183, 368);
            this.lblMatKhauDung.Name = "lblMatKhauDung";
            this.lblMatKhauDung.Size = new System.Drawing.Size(102, 13);
            this.lblMatKhauDung.TabIndex = 21;
            this.lblMatKhauDung.Text = "mật khẩu chính xác";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(182, 339);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '✱';
            this.txtMatKhau.Size = new System.Drawing.Size(201, 26);
            this.txtMatKhau.TabIndex = 20;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên Đăng Nhập:";
            // 
            // dpkNgaySinh
            // 
            this.dpkNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgaySinh.Location = new System.Drawing.Point(183, 117);
            this.dpkNgaySinh.Name = "dpkNgaySinh";
            this.dpkNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dpkNgaySinh.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(184, 167);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 26);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSinhVien.Location = new System.Drawing.Point(183, 69);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(201, 26);
            this.txtTenSinhVien.TabIndex = 5;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSinhVien.Location = new System.Drawing.Point(184, 19);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(143, 26);
            this.txtMaSinhVien.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(531, 534);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 22;
            this.lineShape1.X2 = 519;
            this.lineShape1.Y1 = 307;
            this.lineShape1.Y2 = 309;
            // 
            // frmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThongTinSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongTinSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frmThongTinSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKhongKhop;
        private System.Windows.Forms.Label lblTrungKhop;
        private System.Windows.Forms.Label lblUserNameAvaiable;
        private System.Windows.Forms.Label lblUserNameNotValid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerifyPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpkNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblMatKhauSai;
        private System.Windows.Forms.Label lblMatKhauDung;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDoiTenDangNhap;
        private System.Windows.Forms.TextBox txtSoSachMuon;
        private System.Windows.Forms.Label label10;
    }
}