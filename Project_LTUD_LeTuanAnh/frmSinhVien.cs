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
    /// FORM SINH VIEN
    /// Author: Le Tuan Anh
    /// </summary>

    public partial class frmSinhVien : Form
    {
        DB db = new DB();

        //sudent's information is saved here
        SinhVien sv = (SinhVien) Program.user;

        string maSachMuon = "";

        public frmSinhVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load form, get data to listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            //===Greeting
            lblTenSinhVien.Text = Program.user.getName();

            //===parse data to list view
            //===SACH LISTVIEW===
            lstSach.Columns.Add("Mã Sách", 80, HorizontalAlignment.Center);
            lstSach.Columns.Add("Tên Sách", 175, HorizontalAlignment.Center);
            lstSach.Columns.Add("Tác giả", 75);
            lstSach.Columns.Add("Thể loại", 80);
            lstSach.Columns.Add("Tình trạng", 50);
            lstSach.Columns.Add("Mô Tả", 500);
            lstSach.GridLines = true;
            lstSach.FullRowSelect = true;
            lstSach.MultiSelect = false;
            lstSach.View = View.Details;

            DataTable sach = db.getDataFromTable("SACH");
            sach.Rows[0].Delete();
            getDataFromSach(sach);

            //===COMBO-BOX==
            cboTimSach.Items.Add("Mã sách");
            cboTimSach.Items.Add("tên sách");
            cboTimSach.Items.Add("tác giả");
            cboTimSach.SelectedIndex = 0;

            if (sv.getTinhTrangMuon() == 3)
            {
                btnDatMuon.Enabled = false;
                ToolTip tt = new ToolTip();
                tt.SetToolTip(btnDatMuon, "Số sách bạn mượn đã đạt 3 quyển, hãy trả sách trước khi mượn tiếp");
            }
        }

        /// <summary>
        /// Create Object ID automatically
        ///     upgrade ID 1 unit
        ///     
        ///     for example: TG0999 -> TG1000
        /// </summary>
        /// <param name="oldId">last ID of object in it's list</param>
        /// <param name="s1">fist character</param>
        /// <param name="s2">second character</param>
        /// <returns>new ID</returns>
        private string createID(string oldId, string s1, string s2)
        {
            string[] strID = new string[6];

            strID[0] = s1;
            strID[1] = s2;

            for (int i = 2; i < 6; i++)
            {
                strID[i] = oldId.Substring(i, 1);
            }

            int soDu = 1;
            for (int i = 5; i > 1; i--)
            {
                int n = Convert.ToInt32(strID[i]) + soDu;
                strID[i] = (n % 10).ToString();
                soDu = n / 10;
            }

            return string.Join("", strID);
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
        /// get data, with the first row
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
        /// when clicked to a row
        ///     view book information
        ///     change book ID to borrow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sach = new DataTable();

            if (lstSach.SelectedItems.Count > 0)
            {
                string maSach = lstSach.SelectedItems[0].SubItems[0].Text;
                maSachMuon = maSach;
                sach = db.findSachByID(maSach);

                lblTensach.Text = sach.Rows[0][1].ToString();
                string tenTG = db.getNameByID(sach.Rows[0][2].ToString(),"TACGIA");
                lblTenTacGia.Text = tenTG;
                string theLoai = db.getNameByID(sach.Rows[0][3].ToString(), "THELOAI");
                lblLoai.Text = theLoai;
                lblSoTrang.Text = sach.Rows[0][4].ToString() + " tr";
                string nhaXB = db.getNameByID(sach.Rows[0][5].ToString(), "NHAXUATBAN");
                lblNhaXuatBan.Text = nhaXB;
                lblNamXuatBan.Text = sach.Rows[0][6].ToString();
                lblGiaBia.Text = sach.Rows[0][7].ToString() + " VNĐ";
                ttxtTongTinSach.Text = sach.Rows[0][8].ToString();
            }            
        }

        /// <summary>
        /// save PhieuMuon
        /// update status to book and sinhvien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatMuon_Click(object sender, EventArgs e)
        {
            if (lstSach.SelectedItems[0].SubItems[4].Text == "Còn")
            {

                DataTable phieuMuon = db.getDataFromTable("PHIEUMUON");

                string maPhieu = createID(phieuMuon.Rows[phieuMuon.Rows.Count - 1][0].ToString(), "P", "M");

                DateTime ngayMuon = DateTime.Now;

                db.addDataToPhieuMuon(maPhieu, Program.user.getID(), maSachMuon, ngayMuon);

                db.updateTinhTrangSach(maSachMuon, 1);
                db.updateTinhTrangSinhVien(Program.user.getID(), (sv.getTinhTrangMuon() + 1));
                sv.setTinhTrangMuon(sv.getTinhTrangMuon() + 1);

                db.updateTinhTrangSach(maSachMuon, 1);

                MessageBox.Show("Đặt mượn sách thành công");

                lstSach.Items.Clear();
                getDataFromSach(db.getDataFromTable("SACH"));

                if (sv.getTinhTrangMuon() == 3)
                {
                    btnDatMuon.Enabled = false;
                    ToolTip tt = new ToolTip();
                    tt.SetToolTip(btnDatMuon, "Số sách bạn mượn đã đạt 3 quyển, hãy trả sách trước khi mượn tiếp");
                }
            }
            else
            {
                MessageBox.Show("Đã có người khác mượn sách này, hãy chọn sách khác");
            }
        }

        /// <summary>
        /// refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinhVien sv = new frmSinhVien();
            sv.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_ttDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// view student information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_ttTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTinSinhVien ttSv = new frmThongTinSinhVien();
            ttSv.ShowDialog();
            this.Close();
        }

        
    }
}
