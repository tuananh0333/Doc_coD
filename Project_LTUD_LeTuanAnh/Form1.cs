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
    /// FORM LOGIN
    /// Author: Le Tuan Anh
    /// </summary>
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        /// <summary>
        /// Login, divied into 2 ways:
        ///     if rad nhanvien is on, login into NhanVien database
        ///     else, login into SinhVien database
        /// return to correlative form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (radNhanVien.Checked)
            {
                DataTable nhanvien = db.getDataFromTable("NHANVIEN");
                int isloged = 0;

                for (int i = 0; i < nhanvien.Rows.Count; i++)
                {
                    string userName = nhanvien.Rows[i][1].ToString().Split(' ')[0];
                    string passWord = nhanvien.Rows[i][3].ToString().Split(' ')[0];

                    if (txtUserName.Text == userName)
                    {
                        if (txtMatKhau.Text == passWord)
                        {
                            Program.user = new NhanVien(nhanvien.Rows[i][0].ToString(), nhanvien.Rows[i][1].ToString(), nhanvien.Rows[i][2].ToString(), nhanvien.Rows[i][3].ToString());
                            this.Hide();
                            frmNhanVien nv = new frmNhanVien();
                            nv.ShowDialog();
                            isloged = 1;
                            this.Close();
                        }
                    }
                }
                if (isloged == 0)
                {
                    lblError.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
                    errorProvider1.SetError(txtMatKhau, "hsushu");
                }
            }
            else
            {
                DataTable sinhvien = db.getDataFromTable("SINHVIEN");
                int isloged = 0;
                for (int i = 0; i < sinhvien.Rows.Count; i++)
                {
                    string userName = sinhvien.Rows[i][1].ToString().Split(' ')[0];
                    string passWord = sinhvien.Rows[i][6].ToString().Split(' ')[0];

                    if (txtUserName.Text == userName)
                    {
                        if (txtMatKhau.Text == passWord)
                        {
                            Program.user = new SinhVien(sinhvien.Rows[i][0].ToString(), sinhvien.Rows[i][1].ToString(), sinhvien.Rows[i][2].ToString(), sinhvien.Rows[i][3].ToString(), sinhvien.Rows[i][4].ToString(), Convert.ToInt32(sinhvien.Rows[i][5].ToString()), sinhvien.Rows[i][6].ToString());
                            this.Hide();
                            frmSinhVien nv = new frmSinhVien();
                            nv.ShowDialog();
                            isloged = 1;
                            this.Close();
                        }
                    }
                }
                if (isloged == 0)
                {
                    lblError.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
                }
            }

        }

    }
}
