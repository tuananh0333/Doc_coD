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
    /// Control Book infomation form
    /// Author: Lê Tuấn Anh
    /// </summary>
    public partial class frmThongTinSach : Form
    {
        DB db = new DB();

        public frmThongTinSach()
        {
            InitializeComponent();
        }

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {
            txtTenSach.Focus();

            /*===can not change ID and status*/
            txtMaSach.Enabled = false;
            txtTinhTrangMuon.Enabled = false;

            /*===COMBOBOXES===*/
            DataTable tacGia = db.getDataFromTable("TACGIA");
            for(int i = 1; i < tacGia.Rows.Count; i++)
            {
                string tgName = tacGia.Rows[i][1].ToString();
                cboTenTacGia.Items.Add(tgName);
            }
            DataTable theLoai = db.getDataFromTable("THELOAI");
            for (int i = 1; i < theLoai.Rows.Count; i++)
            {
                string tlName = theLoai.Rows[i][1].ToString();
                cboTheLoai.Items.Add(tlName);
            }
            DataTable nhaXuatBan = db.getDataFromTable("NHAXUATBAN");
            for (int i = 1; i < nhaXuatBan.Rows.Count; i++)
            {
                string nxbName = nhaXuatBan.Rows[i][1].ToString();
                cboNhaXuatBan.Items.Add(nxbName);
            }

            /*===View Book informations===*/
            txtMaSach.Text = Program.sach.getMaSach();
            txtTenSach.Text = Program.sach.getTenSach();
            cboTenTacGia.Text = db.getNameByID(Program.sach.getMaTacGia(), "TACGIA");
            cboTheLoai.Text = db.getNameByID(Program.sach.getMaTheLoai(), "THELOAI");
            txtSoTrang.Text = Program.sach.getSoTrang().ToString();
            txtNamXB.Text = Program.sach.getNamXB().ToString();
            cboNhaXuatBan.Text = db.getNameByID(Program.sach.getMaNXB(), "NHAXUATBAN");
            txtGiaBia.Text = Program.sach.getGiaBia().ToString();
            rtxtNoiDung.Text = Program.sach.getNoiDung();
            txtTinhTrangMuon.Text = (Program.sach.getTinhTrangMuon().ToString() == "0") ? "Đã mượn" : "Còn";

            /*===Add object field===*/
            txtThemNXB.Enabled = false;
            txtThemTacGia.Enabled = false;
            txtThemTheLoai.Enabled = false;
            btnLuuNXB.Enabled = false;
            btnLuuTacGia.Enabled = false;
            btnLuuTheLoai.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Bạn có muốn thêm sách này?", "Thêm sách", MessageBoxButtons.YesNo);
            if (dir == DialogResult.Yes)
            { 
                string tacGia = db.getObjectsIDbyName(cboTenTacGia.Text, "TACGIA");
                string theLoai = db.getObjectsIDbyName(cboTheLoai.Text, "THELOAI");
                string nxb = db.getObjectsIDbyName(cboNhaXuatBan.Text, "NHAXUATBAN");
                db.updateSachInfo(txtMaSach.Text, txtTenSach.Text, tacGia, theLoai, Convert.ToInt32( txtSoTrang.Text), nxb, Convert.ToInt32( txtNamXB.Text), Convert.ToInt32( txtGiaBia.Text), rtxtNoiDung.Text);

                this.Close();
            }
        }

        /// <summary>
        /// Click to enable tools to add new objects
        /// </summary>
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            txtThemTacGia.Enabled = true;
            btnLuuTacGia.Enabled = true;
        }
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            txtThemTheLoai.Enabled = true;
            btnLuuTheLoai.Enabled = true;
        }
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            txtThemNXB.Enabled = true;
            btnLuuNXB.Enabled = true;
        }

        /// <summary>
        /// Click to add objects when it not exist in database
        ///     -> add to database and choose it
        /// </summary>
        private void btnLuuTacGia_Click(object sender, EventArgs e)
        {
            if (txtThemTacGia.Text != "")
            {
                DialogResult dir = MessageBox.Show("Bạn muốn thêm 1 tác giả mới: " + txtThemTacGia.Text, "Thêm tác giả", MessageBoxButtons.YesNo);
                if (dir == DialogResult.Yes)
                {
                    string tenTacGia = txtThemTacGia.Text;
                    string maTacGia = "";

                    DataTable tacGia = new DataTable();
                    tacGia = db.getDataFromTable("TACGIA");
                    //add new author to database
                    maTacGia = createID(tacGia.Rows[tacGia.Rows.Count - 1][0].ToString(), "T", "G");
                    db.addDataToTiniObjects(maTacGia, tenTacGia, "TACGIA");
                    //add new author to combobox and choose him
                    cboTenTacGia.Items.Add(tenTacGia);
                    cboTenTacGia.SelectedIndex = cboTenTacGia.Items.Count - 1;

                    //make it brain new
                    txtThemTacGia.Text = "";
                    txtThemTacGia.Enabled = false;
                    btnLuuTacGia.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("không được để trống thông tin");
            }
        }
        /// <summary>
        /// Click to add objects when it not exist in database
        ///     -> add to database and choose it
        /// </summary>
        private void btnLuuTheLoai_Click(object sender, EventArgs e)
        {
            if (txtThemTheLoai.Text != "")
            {
                DialogResult dir = MessageBox.Show("Bạn muốn thêm 1 thể loại mới: " + txtThemTacGia.Text, "Thêm thể loại", MessageBoxButtons.YesNo);
                if (dir == DialogResult.Yes)
                {
                    string tenTheLoai = txtThemTheLoai.Text;
                    string maTheLoai = "";

                    DataTable tacGia = new DataTable();
                    tacGia = db.getDataFromTable("THELOAI");
                    //add new type to database
                    maTheLoai = createID(tacGia.Rows[tacGia.Rows.Count - 1][0].ToString(), "T", "L");
                    db.addDataToTiniObjects(maTheLoai, tenTheLoai, "THELOAI");
                    //add new type to combobox and choose it
                    cboTheLoai.Items.Add(tenTheLoai);
                    cboTheLoai.SelectedIndex = cboTheLoai.Items.Count - 1;

                    //make it brain new
                    txtThemTheLoai.Text = "";
                    txtThemTheLoai.Enabled = false;
                    btnLuuTheLoai.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("không được để trống thông tin");
            }
        }
        /// <summary>
        /// Click to add objects when it not exist in database
        ///     -> add to database and choose it
        /// </summary>
        private void btnLuuNXB_Click(object sender, EventArgs e)
        {
            if (txtThemTheLoai.Text != "")
            {
                DialogResult dir = MessageBox.Show("Bạn muốn thêm 1 nhà xuất bản mới: " + txtThemTacGia.Text, "Thêm nhà xuất bản", MessageBoxButtons.YesNo);
                if (dir == DialogResult.Yes)
                {
                    string tenNXB = txtThemNXB.Text;
                    string maNXB = "";

                    DataTable tacGia = new DataTable();
                    tacGia = db.getDataFromTable("NHAXUATBAN");
                    //add new type to database
                    maNXB = createID(tacGia.Rows[tacGia.Rows.Count - 1][0].ToString(), "X", "B");
                    db.addDataToTiniObjects(maNXB, tenNXB, "NHAXUATBAN");
                    //add new type to combobox and choose it
                    cboNhaXuatBan.Items.Add(tenNXB);
                    cboNhaXuatBan.SelectedIndex = cboNhaXuatBan.Items.Count - 1;

                    //make it brain new
                    txtThemNXB.Text = "";
                    txtThemNXB.Enabled = false;
                    btnLuuNXB.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("không được để trống thông tin");
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
    }
}
