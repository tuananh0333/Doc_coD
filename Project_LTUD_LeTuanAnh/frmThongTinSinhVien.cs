using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_LTUD_LeTuanAnh
{
    /// <summary>
    /// FORM STUDENT INFORMATION
    /// Author: Le Tuan Anh
    /// </summary>
    public partial class frmThongTinSinhVien : Form
    {
        DB db = new DB();
        frmSinhVien frmSV = new frmSinhVien();
        
        SinhVien sv = (SinhVien)Program.user;
                
        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            frmSV.Hide();

            txtMaSinhVien.Enabled = false;
            txtSoSachMuon.Enabled = false;

            txtUserName.Enabled = false;

            txtMatKhau.Enabled = true;
            txtNewPassword.Enabled = false;
            txtVerifyPassword.Enabled = false;

            btnChangePassword.Enabled = false;
            btnDoiTenDangNhap.Enabled = false;

            dpkNgaySinh.Format = DateTimePickerFormat.Short;

            txtMaSinhVien.Text = sv.getID();
            txtTenSinhVien.Text = sv.getName();
            dpkNgaySinh.Text = sv.getNgaySinh();
            txtDiaChi.Text = sv.getDiaChi();
            txtSoSachMuon.Text = sv.getTinhTrangMuon().ToString();
            txtUserName.Text = sv.getUserName().Split(' ')[0];

            lblUserNameAvaiable.Text = "";
            lblUserNameNotValid.Text = "";
            lblMatKhauDung.Text = "";
            lblMatKhauSai.Text = "";
            lblKhongKhop.Text = "";//Verify
            lblTrungKhop.Text = "";//Verify
        }

        /// <summary>
        /// validate user name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            DataTable sinhvien = db.getDataFromTable("SINHVIEN");

            bool success = true;

            if (txtUserName.Text.Length < 6)
            {
                lblUserNameNotValid.Text = "Tên quá ngắn";
                btnDoiTenDangNhap.Enabled = false;
            }
            else
            {
                for (int i = 0; i < sinhvien.Rows.Count; i++)
                {
                    if (txtUserName.Text == sinhvien.Rows[i][1].ToString().Split(' ')[0])
                    {
                        lblUserNameNotValid.Text = "tài khoản đã tồn tại";
                        lblUserNameAvaiable.Text = "";

                        btnDoiTenDangNhap.Enabled = false;

                        success = false;
                        break;
                    }
                }
                if (success && txtMatKhau.Text != "")
                {
                    lblUserNameAvaiable.Text = "có thể sử dụng tên này";
                    lblUserNameNotValid.Text = "";
                    
                    btnDoiTenDangNhap.Enabled = true;
                }
            }
        }

        /// <summary>
        /// confirm password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == Program.user.getPassword().Split(' ')[0])
            {
                txtNewPassword.Enabled = true;
                txtVerifyPassword.Enabled = true;

                txtUserName.Enabled = true;
                btnDoiTenDangNhap.Enabled = true;

                lblMatKhauDung.Text = "Mật khẩu chính xác";
                lblMatKhauSai.Text = "";
            }
            else
            {
                lblMatKhauSai.Text = "Mật khẩu không đúng";
                lblMatKhauDung.Text = "";

                btnChangePassword.Enabled = false;
                btnDoiTenDangNhap.Enabled = false;

                txtNewPassword.Enabled = false;
                txtVerifyPassword.Enabled = false;
                txtUserName.Enabled = false;
            }
        }

        /// <summary>
        /// verify password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtVerifyPassword.Text && txtNewPassword.Text != "")
            {
                btnChangePassword.Enabled = true;
                lblTrungKhop.Text = "Mật khẩu xác nhận chính xác";
                lblKhongKhop.Text = "";
            }
            else
            {
                lblKhongKhop.Text = "Mật khẩu xác nhận không đúng";
                lblTrungKhop.Text = "";

                btnChangePassword.Enabled = false;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            lblKhongKhop.Text = "";
            lblTrungKhop.Text = "";

            btnChangePassword.Enabled = false;
        }

        private void btnDoiTenDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Sau khi đổi tên đăng nhập, bạn phải đăng nhập lại","Đổi tên đăng nhập",MessageBoxButtons.YesNo);
            if (dir == DialogResult.Yes)
            {
                db.updateSinhVienUserName(txtMaSinhVien.Text, txtUserName.Text);

                MessageBox.Show("Đổi tên đăng nhập thành công, mời đăng nhập lại");

                this.Hide();
                Form1 main = new Form1();
                main.ShowDialog();
                frmSV.Close();
                this.Close();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Sau khi đổi mật khẩu, bạn phải đăng nhập lại", "Đổi mật khẩu", MessageBoxButtons.YesNo);
            if (dir == DialogResult.Yes)
            {
                db.updateSinhVienPassword(txtMaSinhVien.Text, txtNewPassword.Text);

                MessageBox.Show("Đổi mật khẩu thành công, mời đăng nhập lại");

                this.Hide();
                Form1 main = new Form1();
                main.ShowDialog();
                frmSV.Close();
                this.Close();
            }
        }
        
        private void frmThongTinSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmSV.ShowDialog();
        }
    }
}
