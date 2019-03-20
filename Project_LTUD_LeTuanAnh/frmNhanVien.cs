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
    /// FORM STAFF
    /// Author: Le Tuan Anh
    /// </summary>
    public partial class frmNhanVien : Form
    {
        //public static string maSach;
        DB db = new DB();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load form, View all book and student to 2 list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //===SACH LISTVIEW===
            lstSach.Columns.Add("Mã Sách",80, HorizontalAlignment.Center);
            lstSach.Columns.Add("Tên Sách",175, HorizontalAlignment.Center);
            lstSach.Columns.Add("Tác giả",75);
            lstSach.Columns.Add("Thể loại",80);
            lstSach.Columns.Add("Tình trạng", 50);
            lstSach.Columns.Add("Mô Tả",200);
            lstSach.GridLines = true;
            lstSach.FullRowSelect = true;
            lstSach.MultiSelect = false;
            lstSach.View = View.Details;

            DataTable sach = db.getDataFromTable("SACH");
            sach.Rows[0].Delete();
            getDataFromSach(sach);

            //===SINH VIEN LISTVIEW===
            lstSinhVien.Columns.Add("Mã sinh viên", 80, HorizontalAlignment.Center);
            lstSinhVien.Columns.Add("Tên sinh viên", 175, HorizontalAlignment.Center);
            lstSinhVien.Columns.Add("Ngày sinh", 80);
            lstSinhVien.Columns.Add("Địa chỉ", 200);
            lstSinhVien.Columns.Add("Tình trạng mượn", 100, HorizontalAlignment.Left);
            lstSinhVien.GridLines = true;
            lstSinhVien.FullRowSelect = true;
            lstSinhVien.MultiSelect = false;
            lstSinhVien.View = View.Details;

            DataTable sv = db.getDataFromTable("SINHVIEN");
            sv.Rows[0].Delete();
            getDataFromSinhVien(sv);

            //===COMBO-BOXES==
            cboTimSach.Items.Add("Mã sách");
            cboTimSach.Items.Add("tên sách");
            cboTimSach.Items.Add("tác giả");
            cboTimSach.SelectedIndex = 0;

            cboTimSV.Items.Add("Mã sinh viên");
            cboTimSV.Items.Add("tên sinh viên");
            cboTimSV.SelectedIndex = 0;

            //===WELCOME LABLE===
            lblTenNhanVien.Text = Program.user.getName();
        }

        /// <summary>
        /// get book's info when choose it in book list view
        /// </summary>
        private void lstSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sach = db.getDataFromTable("SACH");

            if (lstSach.SelectedItems.Count > 0)
            {
                string maSach = sach.Rows[lstSach.SelectedItems[0].Index + 1][0].ToString();
                string tenSach = sach.Rows[lstSach.SelectedItems[0].Index + 1][1].ToString();
                string tenTacGia = sach.Rows[lstSach.SelectedItems[0].Index + 1][2].ToString();
                string theLoai = sach.Rows[lstSach.SelectedItems[0].Index + 1][3].ToString();
                int soTrang = Convert.ToInt32(sach.Rows[lstSach.SelectedItems[0].Index + 1][4].ToString());
                string nhaXB = sach.Rows[lstSach.SelectedItems[0].Index + 1][5].ToString();
                int namXB = Convert.ToInt32(sach.Rows[lstSach.SelectedItems[0].Index + 1][6].ToString());
                int gia = Convert.ToInt32(sach.Rows[lstSach.SelectedItems[0].Index + 1][7].ToString());
                string noiDung = sach.Rows[lstSach.SelectedItems[0].Index + 1][8].ToString();
                bool tinhTrang = Convert.ToBoolean(Convert.ToInt32(sach.Rows[lstSach.SelectedItems[0].Index + 1][9].ToString()));

                Program.sach = new Sach(maSach, tenSach, tenTacGia, theLoai, soTrang, nhaXB, namXB, gia, noiDung, tinhTrang);
            }
            
        }

        /// <summary>
        /// parse data from database to book list view
        /// </summary>
        /// <param name="data"></param>
        private void getDataFromSach(DataTable data)
        {
            for (int i = 1; i < data.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(data.Rows[i][0].ToString());
                item.SubItems.Add(data.Rows[i][1].ToString());
                item.SubItems.Add(db.getNameByID(data.Rows[i][2].ToString(),"TACGIA"));
                item.SubItems.Add(db.getNameByID(data.Rows[i][3].ToString(), "THELOAI"));
                string tinhTrang = "";
                if (Convert.ToInt32(data.Rows[i][9].ToString()) == 0)
                {
                    tinhTrang = "Còn";
                }
                else
                {
                    tinhTrang = "Đã mượn";
                }
                item.SubItems.Add(tinhTrang);
                item.SubItems.Add(data.Rows[i][8].ToString());
                lstSach.Items.Add(item);
            }
        }

        /// <summary>
        /// load data to list view after click serch button, not hide the first row
        /// </summary>
        /// <param name="data"></param>
        private void getDataFromTimSach(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(data.Rows[i][0].ToString());
                item.SubItems.Add(data.Rows[i][1].ToString());
                item.SubItems.Add(db.getNameByID(data.Rows[i][2].ToString(), "TACGIA"));
                item.SubItems.Add(db.getNameByID(data.Rows[i][3].ToString(), "THELOAI"));
                string tinhTrang = "";
                if (Convert.ToInt32(data.Rows[i][9].ToString()) == 0)
                {
                    tinhTrang = "Còn";
                }
                else
                {
                    tinhTrang = "Đã mượn";
                }
                item.SubItems.Add(tinhTrang);
                item.SubItems.Add(data.Rows[i][8].ToString());
                lstSach.Items.Add(item);
            }
        }

        /// <summary>
        /// parse database to Student list view
        /// </summary>
        private void getDataFromSinhVien(DataTable data)
        {
            for (int i = 1; i < data.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(data.Rows[i][0].ToString());
                item.SubItems.Add(data.Rows[i][2].ToString());
                item.SubItems.Add(data.Rows[i][3].ToString().Split(' ')[0]);
                item.SubItems.Add(data.Rows[i][4].ToString());
                item.SubItems.Add(data.Rows[i][5].ToString());
                lstSinhVien.Items.Add(item);
            }
        }

        /// <summary>
        /// Log out, return to main form
        /// </summary>
        private void TSMItem_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.ShowDialog();
            this.Close();
        }


        /// <summary>
        /// click to delete a book
        /// </summary>
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (lstSach.SelectedItems.Count == 1)
            {
                DialogResult dir = MessageBox.Show("Bạn có muốn xóa quyển sách này?", "xóa sách", MessageBoxButtons.YesNo);
                if (dir == DialogResult.Yes)
                {
                    if (lstSach.SelectedItems[0].SubItems[4].Text == "Còn")
                    {
                        db.deleteDataFromTable(lstSach.SelectedItems[0].Text, "SACH");
                        DataTable sach = db.getDataFromTable("SACH");
                        lstSach.Items.Clear();
                        getDataFromSach(sach);
                    }
                    else
                    {
                        MessageBox.Show("Sách này đang được mượn, không thể xóa");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời bạn chọn một quyển sách");
            }
        }

        /// <summary>
        /// click to delete a student
        /// </summary>
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedItems.Count == 1)
            {
                DialogResult dir = MessageBox.Show("Bạn có muốn xóa sinh viên này?", "xóa sinh viên", MessageBoxButtons.YesNo);
                if (dir == DialogResult.Yes)
                {
                    if (Convert.ToInt32(lstSinhVien.SelectedItems[0].SubItems[4].Text) == 0)
                    {
                        db.deleteDataFromTable(lstSinhVien.SelectedItems[0].Text, "SINHVIEN");
                        
                        DataTable sinhVien = db.getDataFromTable("SINHVIEN");
                        lstSinhVien.Items.Clear();
                        getDataFromSinhVien(sinhVien);
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên này đang nợ sách, không thể xóa");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời bạn chọn một sinh viên");
            }
        }

        /// <summary>
        /// click to update book's information
        /// </summary>
        private void btnThongTinSach_Click(object sender, EventArgs e)
        {
            if (lstSach.SelectedItems.Count == 1)
            {
                frmThongTinSach thongTinSach = new frmThongTinSach();
                thongTinSach.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 cuốn sách");
            }
        }

        /// <summary>
        /// refresh form Staff window, update info
        /// </summary>
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien nhanvien = new frmNhanVien();
            nhanvien.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// find book
        ///     by ID
        ///     by name
        ///     by author's name
        ///     
        /// following cboTimSach's value
        /// </summary>
        private void btnTimSach_Click(object sender, EventArgs e)
        {
            lstSach.Items.Clear();

            DataTable findBook = new DataTable();
            if (cboTimSach.SelectedIndex == 0)
            {
                findBook = db.findSachByID(txtTimSach.Text);
                getDataFromTimSach(findBook);
            }
            else if (cboTimSach.SelectedIndex == 1)
            {
                findBook = db.findSachByName(txtTimSach.Text);
                getDataFromTimSach(findBook);
            }
            else if (cboTimSach.SelectedIndex == 2)
            {
                findBook = db.findSachByAuthorName(txtTimSach.Text);
                getDataFromTimSach(findBook);
            }
        }

        /// <summary>
        /// find student
        ///     by ID
        ///     by name
        ///     
        /// following cboTimSV's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimSV_Click(object sender, EventArgs e)
        {
            lstSinhVien.Items.Clear();

            DataTable findSV = new DataTable();

            if (cboTimSV.SelectedIndex == 0)
            { 
                findSV = db.findSinhVienByID(txtTimSV.Text);
            }
            else if (cboTimSV.SelectedIndex == 1)
            {
                findSV = db.findSinhVienByName(txtTimSV.Text);
            }

            getDataFromSinhVien(findSV);
        }

        /// <summary>
        /// Click to view staff's profile
        /// </summary>
        private void TSMItem_ttTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien nhanvien = new frmThongTinNhanVien();
            nhanvien.ShowDialog();
        }

        private void TSMI_quanLy_Click(object sender, EventArgs e)
        {
            frmQuanLyObjects quanly = new frmQuanLyObjects();
            quanly.ShowDialog();
        }

        private void TSMItem_addSV_Click(object sender, EventArgs e)
        {
            frmDangKySinhVien dky = new frmDangKySinhVien();
            dky.ShowDialog();
        }

        private void TSMItem_addSach_Click(object sender, EventArgs e)
        {
            frmThemsach themsach = new frmThemsach();
            themsach.ShowDialog();
        }

        private void TSMI_traSach_Click(object sender, EventArgs e)
        {
            frmPhieuMuon phieuMuon = new frmPhieuMuon();
            phieuMuon.ShowDialog();
        }
    }
}
