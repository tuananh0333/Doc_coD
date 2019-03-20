namespace Project_LTUD_LeTuanAnh
{
    partial class frmThongTinNhanVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserNameAvaiable = new System.Windows.Forms.Label();
            this.lblUserNameNotValid = new System.Windows.Forms.Label();
            this.lblXNSuccess = new System.Windows.Forms.Label();
            this.lblXNFail = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnLuuMatKhau = new System.Windows.Forms.Button();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUserNameAvaiable);
            this.groupBox1.Controls.Add(this.lblUserNameNotValid);
            this.groupBox1.Controls.Add(this.lblXNSuccess);
            this.groupBox1.Controls.Add(this.lblXNFail);
            this.groupBox1.Controls.Add(this.lblFail);
            this.groupBox1.Controls.Add(this.lblSuccess);
            this.groupBox1.Controls.Add(this.btnLuuMatKhau);
            this.groupBox1.Controls.Add(this.txtXacNhanMatKhau);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMatKhauMoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDoiMatKhau);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(83, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 358);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblUserNameAvaiable
            // 
            this.lblUserNameAvaiable.AutoSize = true;
            this.lblUserNameAvaiable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUserNameAvaiable.Location = new System.Drawing.Point(215, 127);
            this.lblUserNameAvaiable.Name = "lblUserNameAvaiable";
            this.lblUserNameAvaiable.Size = new System.Drawing.Size(116, 13);
            this.lblUserNameAvaiable.TabIndex = 19;
            this.lblUserNameAvaiable.Text = "có thể sử dụng tên này";
            // 
            // lblUserNameNotValid
            // 
            this.lblUserNameNotValid.AutoSize = true;
            this.lblUserNameNotValid.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameNotValid.Location = new System.Drawing.Point(215, 127);
            this.lblUserNameNotValid.Name = "lblUserNameNotValid";
            this.lblUserNameNotValid.Size = new System.Drawing.Size(99, 13);
            this.lblUserNameNotValid.TabIndex = 18;
            this.lblUserNameNotValid.Text = "tài khoản đã tồn tại";
            // 
            // lblXNSuccess
            // 
            this.lblXNSuccess.AutoSize = true;
            this.lblXNSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblXNSuccess.Location = new System.Drawing.Point(213, 289);
            this.lblXNSuccess.Name = "lblXNSuccess";
            this.lblXNSuccess.Size = new System.Drawing.Size(150, 13);
            this.lblXNSuccess.TabIndex = 17;
            this.lblXNSuccess.Text = "Mật khẩu xác nhận chính xác";
            // 
            // lblXNFail
            // 
            this.lblXNFail.AutoSize = true;
            this.lblXNFail.ForeColor = System.Drawing.Color.Red;
            this.lblXNFail.Location = new System.Drawing.Point(213, 289);
            this.lblXNFail.Name = "lblXNFail";
            this.lblXNFail.Size = new System.Drawing.Size(184, 13);
            this.lblXNFail.TabIndex = 16;
            this.lblXNFail.Text = "Xác nhận mật khẩu không chính xác";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.ForeColor = System.Drawing.Color.Red;
            this.lblFail.Location = new System.Drawing.Point(213, 181);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(136, 13);
            this.lblFail.TabIndex = 15;
            this.lblFail.Text = "Mật khẩu không chính xác";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblSuccess.Location = new System.Drawing.Point(213, 181);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(103, 13);
            this.lblSuccess.TabIndex = 14;
            this.lblSuccess.Text = "Mật khẩu chính xác";
            // 
            // btnLuuMatKhau
            // 
            this.btnLuuMatKhau.Location = new System.Drawing.Point(216, 311);
            this.btnLuuMatKhau.Name = "btnLuuMatKhau";
            this.btnLuuMatKhau.Size = new System.Drawing.Size(101, 23);
            this.btnLuuMatKhau.TabIndex = 13;
            this.btnLuuMatKhau.Text = "Lưu mật khẩu";
            this.btnLuuMatKhau.UseVisualStyleBackColor = true;
            this.btnLuuMatKhau.Click += new System.EventHandler(this.btnLuuMatKhau_Click);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(216, 262);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '✱';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(203, 24);
            this.txtXacNhanMatKhau.TabIndex = 12;
            this.txtXacNhanMatKhau.TextChanged += new System.EventHandler(this.txtXacNhanMatKhau_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Xác nhận mật khẩu:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(216, 232);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '✱';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(203, 24);
            this.txtMatKhauMoi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mật khẩu mới:";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(216, 203);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(101, 23);
            this.btnDoiMatKhau.TabIndex = 8;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(216, 61);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(203, 24);
            this.txtTenNhanVien.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(216, 100);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(203, 24);
            this.txtTenDangNhap.TabIndex = 6;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(216, 150);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '✱';
            this.txtMatKhau.Size = new System.Drawing.Size(203, 24);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(216, 19);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(203, 24);
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThongTin.Location = new System.Drawing.Point(263, 443);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(111, 32);
            this.btnLuuThongTin.TabIndex = 4;
            this.btnLuuThongTin.Text = "Lưu";
            this.btnLuuThongTin.UseVisualStyleBackColor = true;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // frmThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 492);
            this.Controls.Add(this.btnLuuThongTin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.frmThongTinNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuuMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblXNSuccess;
        private System.Windows.Forms.Label lblXNFail;
        private System.Windows.Forms.Label lblUserNameAvaiable;
        private System.Windows.Forms.Label lblUserNameNotValid;
    }
}