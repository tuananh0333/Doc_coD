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
    /// FORM CREATE STUDENT ACCOUNT
    /// Author: Le Tuan Anh
    /// </summary>
    public partial class frmDangKySinhVien : Form
    {
        DB db = new DB();

        public frmDangKySinhVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create student ID automatically
        ///     upgrade ID 1 unit
        ///     
        ///     for example: DocoDsv0999 -> DocoDsv1000
        /// </summary>
        /// <param name="oldId">last ID of object in it's list</param>
        /// <returns>new ID</returns>
        private string createStudentID(string oldId)
        {
            string[] strID = new string[11];

            strID[0] = "D";
            strID[1] = "o";
            strID[2] = "c";
            strID[3] = "o";
            strID[4] = "D";
            strID[5] = "s";
            strID[6] = "v";

            for (int i = 7; i < 11; i++)
            {
                strID[i] = oldId.Substring(i, 1);
            }

            int soDu = 1;
            for (int i = 10; i > 6; i--)
            {
                int n = Convert.ToInt32(strID[i]) + soDu;
                strID[i] = (n % 10).ToString();
                soDu = n / 10;
            }

            return string.Join("", strID);
        }

        /// <summary>
        /// load form, create new Student ID to add SinhVien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDangKySinhVien_Load(object sender, EventArgs e)
        {
            dpkNgaySinh.Format = DateTimePickerFormat.Short;
            dpkNgaySinh.Text = "21/05/1997";

            txtMaSinhVien.Enabled = false;
            DataTable sinhvien = db.getDataFromTable("SINHVIEN");
            txtMaSinhVien.Text = createStudentID(sinhvien.Rows[sinhvien.Rows.Count - 1][0].ToString());

            lblPassNotSuccess.Text = "";
            lblPassSuccess.Text = "";
            lblUserNameAvaiable.Text = "";
            lblUserNameNotValid.Text = "";

            txtPassword.Enabled = false;
            txtVerifyPassword.Enabled = false;

            btnCreateAccount.Enabled = false;
        }

        /// <summary>
        /// Validate UserName
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
            }
            else
            {
                for (int i = 0; i < sinhvien.Rows.Count; i++)
                {
                    if (txtUserName.Text == sinhvien.Rows[i][1].ToString().Split(' ')[0])
                    {
                        lblUserNameNotValid.Text = "tài khoản đã tồn tại";
                        lblUserNameAvaiable.Text = "";

                        txtPassword.Enabled = false;
                        txtVerifyPassword.Enabled = false;
                        success = false;
                        break;
                    }
                }
                if (success)
                {
                    lblUserNameAvaiable.Text = "có thể sử dụng tên này";
                    lblUserNameNotValid.Text = "";
                    txtPassword.Enabled = true;
                    txtVerifyPassword.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Verify Password before create an account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtVerifyPassword.Text == txtPassword.Text)
            {
                lblPassSuccess.Text = "mật khẩu chính xác";
                lblPassNotSuccess.Text = "";

                btnCreateAccount.Enabled = true;
            }
            else
            { 
                lblPassSuccess.Text = "";
                lblPassNotSuccess.Text = " mật khẩu không khớp";

                btnCreateAccount.Enabled = false;
            }
        }

        /// <summary>
        /// add new SinhVien to database, make the form Brain new
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtTenSinhVien.Text != "")
            {
                db.addDataToSinhVien(txtMaSinhVien.Text, txtUserName.Text, txtTenSinhVien.Text, dpkNgaySinh.Value, txtDiaChi.Text, txtPassword.Text);

                dpkNgaySinh.Format = DateTimePickerFormat.Short;
                dpkNgaySinh.Text = "21/05/1997";

                txtMaSinhVien.Enabled = false;
                DataTable sinhvien = db.getDataFromTable("SINHVIEN");
                txtMaSinhVien.Text = createStudentID(sinhvien.Rows[sinhvien.Rows.Count - 1][0].ToString());

                lblPassNotSuccess.Text = "";
                lblPassSuccess.Text = "";
                lblUserNameAvaiable.Text = "";
                lblUserNameNotValid.Text = "";

                txtTenSinhVien.Text = "";
                txtUserName.Text = "";
                txtDiaChi.Text = "";
                txtPassword.Text = "";
                txtVerifyPassword.Text = "";

                txtPassword.Enabled = false;
                txtVerifyPassword.Enabled = false;

                btnCreateAccount.Enabled = false;
            }
            else
            {
                MessageBox.Show("không được để trống thông tin");
            }
        }


    }
}
