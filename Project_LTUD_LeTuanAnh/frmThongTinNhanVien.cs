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
    /// FORM NHANVIEN INFOR
    /// Author: Le Tuan Anh
    /// </summary>
    public partial class frmThongTinNhanVien : Form
    {
        DB db = new DB();

        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = Program.user.getID();
            txtTenNhanVien.Text = Program.user.getName();
            txtTenDangNhap.Text = Program.user.getUserName();

            txtMaNhanVien.Enabled = false;

            btnDoiMatKhau.Enabled = false;
            btnLuuMatKhau.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            txtXacNhanMatKhau.Enabled = false;

            lblFail.Text = "";
            lblSuccess.Text = "";
            lblXNFail.Text = "";
            lblXNSuccess.Text = "";
        }


        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.Enabled = true;
            txtXacNhanMatKhau.Enabled = true;
        }

        private void btnLuuMatKhau_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Bạn muốn thay đổi thông tin đăng nhập?", "Đổi thông tin đăng nhập", MessageBoxButtons.YesNo);

            if (dir == DialogResult.Yes)
            {
                db.updateNhanVienAccount(txtMaNhanVien.Text, txtTenDangNhap.Text, txtMatKhauMoi.Text);

                btnDoiMatKhau.Enabled = false;
                btnLuuMatKhau.Enabled = false;
                txtMatKhauMoi.Enabled = false;
                txtXacNhanMatKhau.Enabled = false;

                txtMatKhau.Text = "";
                txtMatKhauMoi.Text = "";
                txtXacNhanMatKhau.Text = "";

                lblFail.Text = "";
                lblSuccess.Text = "";
                lblXNFail.Text = "";
                lblXNSuccess.Text = "";

                DataTable nhanvien = db.getNhanVienByID(txtMaNhanVien.Text);

                Program.user = new User(nhanvien.Rows[0][0].ToString(), nhanvien.Rows[0][1].ToString(), nhanvien.Rows[0][2].ToString(), nhanvien.Rows[0][3].ToString());
                MessageBox.Show("Thay đổi thông tin thành công");
            }
        }

        /// <summary>
        /// update nhanvien's name, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
             DialogResult dir = MessageBox.Show("Bạn muốn thay đổi thông tin cá nhân?", "Đổi thông tin cá nhân", MessageBoxButtons.YesNo);

             if (dir == DialogResult.Yes)
             {
                 db.updateNhanVienName(txtMaNhanVien.Text, txtTenNhanVien.Text);
                 DataTable nhanvien = db.getNhanVienByID(txtMaNhanVien.Text);
                 Program.user = new User(nhanvien.Rows[0][0].ToString(), nhanvien.Rows[0][1].ToString(), nhanvien.Rows[0][2].ToString(), nhanvien.Rows[0][3].ToString());

                 MessageBox.Show("Thay đổi thông tin thành công");

                 btnDoiMatKhau.Enabled = false;
                 btnLuuMatKhau.Enabled = false;
                 txtMatKhauMoi.Enabled = false;
                 txtXacNhanMatKhau.Enabled = false;

                 txtMatKhau.Text = "";
                 txtMatKhauMoi.Text = "";
                 txtXacNhanMatKhau.Text = "";

                 lblFail.Text = "";
                 lblSuccess.Text = "";
                 lblXNFail.Text = "";
                 lblXNSuccess.Text = "";
             }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == Program.user.getPassword().Split(' ')[0])
            {
                btnDoiMatKhau.Enabled = true;
                lblSuccess.Text = "Mật khẩu chính xác";
                lblFail.Text = "";
            }
            else
            {
                lblFail.Text = "Mật khẩu không đúng";
                lblSuccess.Text = "";

                btnDoiMatKhau.Enabled = false;
                btnLuuMatKhau.Enabled = false;
                txtMatKhauMoi.Enabled = false;
                txtXacNhanMatKhau.Enabled = false;
            }
        }

        /// <summary>
        /// validate password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == txtXacNhanMatKhau.Text && txtMatKhauMoi.Text != "")
            {
                btnLuuMatKhau.Enabled = true;
                lblXNSuccess.Text = "Mật khẩu xác nhận chính xác";
                lblXNFail.Text = "";
            }
            else
            {
                lblXNFail.Text = "Mật khẩu xác nhận không đúng";
                lblXNSuccess.Text = "";

                btnLuuMatKhau.Enabled = false;
            }
        }

        /// <summary>
        /// validate new user name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            DataTable nhanvien = db.getDataFromTable("NHANVIEN");

            bool success = true;

            if (txtTenDangNhap.Text.Length < 6)
            {
                lblUserNameNotValid.Text = "Tên quá ngắn";
                lblUserNameAvaiable.Text = "";
                txtMatKhau.Enabled = false;
            }
            else
            {
                for (int i = 0; i < nhanvien.Rows.Count; i++)
                {
                    if (txtTenDangNhap.Text == nhanvien.Rows[i][1].ToString().Split(' ')[0])
                    {
                        lblUserNameNotValid.Text = "tài khoản đã tồn tại";
                        lblUserNameAvaiable.Text = "";

                        txtMatKhau.Enabled = false;

                        success = false;
                        break;
                    }
                }
                if (success)
                {
                    lblUserNameAvaiable.Text = "có thể sử dụng tên này";
                    lblUserNameNotValid.Text = "";

                    txtMatKhau.Enabled = true;
                }
            }
        }
    }
}
