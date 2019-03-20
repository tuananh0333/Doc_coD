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
    /// FORM QUAN LY
    ///     [NHAXUATBAN]
    ///     [TACGIA]
    ///     [THELOAI]
    /// Author: Le Tuan Anh
    /// </summary>
    public partial class frmQuanLyObjects : Form
    {
        DB db = new DB();

        public frmQuanLyObjects()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load form, fill data to datagridviews
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuanLyObjects_Load(object sender, EventArgs e)
        {
            btnXoaNXB.Enabled = false;
            btnSuaNXB.Enabled = false;
            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = false;
            btnLuuNXB.Enabled = false;

            btnXoaTheLoai.Enabled = false;
            btnSuaTheLoai.Enabled = false;
            txtMaTheLoai.Enabled = false;
            txtTenTheLoai.Enabled = false;
            btnLuuTheLoai.Enabled = false;

            btnXoaTacGia.Enabled = false;
            btnSuaTacGia.Enabled = false;
            txtMaTacGia.Enabled = false;
            txtTenTacGia.Enabled = false;
            btnLuuTacGia.Enabled = false;

            DataTable nxb = db.getDataFromTable("NHAXUATBAN");
            nxb.Rows[0].Delete();
            DataTable theloai = db.getDataFromTable("THELOAI");
            theloai.Rows[0].Delete();
            DataTable tacgia = db.getDataFromTable("TACGIA");
            tacgia.Rows[0].Delete();

            dgv_NhaXuatBan.DataSource = nxb;
            dgv_TacGia.DataSource = tacgia;
            dgv_TheLoai.DataSource = theloai;

            dgv_NhaXuatBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_TacGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_TheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        /*===NHAXUATBAN===*/
        /// <summary>
        /// open some funcion when choose a NXB
        /// </summary>
        private void dgv_NhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaNXB.Enabled = true;
            btnSuaNXB.Enabled = true;

            txtMaNXB.Text = dgv_NhaXuatBan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNXB.Text = dgv_NhaXuatBan.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtTenNXB.Enabled = false;

            btnLuuNXB.Enabled = false;
        }

        /// <summary>
        /// click to update NXB
        /// </summary>
        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            txtTenNXB.Enabled = true;

            btnLuuNXB.Enabled = true;
        }
        /// <summary>
        /// click to add NXB with ID created automatically
        /// </summary>
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            txtTenNXB.Enabled = true;
            txtTenNXB.Text = "";
            txtMaNXB.Text = createID(dgv_NhaXuatBan.Rows[dgv_NhaXuatBan.Rows.Count - 2].Cells[0].Value.ToString(), "X", "B");

            btnXoaNXB.Enabled = false;
            btnSuaNXB.Enabled = false;

            btnLuuNXB.Enabled = true;
        }
        /// <summary>
        /// delete NXB, if it belongs to any book, return the book's nxb to "không xác định"
        /// </summary>
        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Bạn có muốn xóa nhà xuất bản này?", "Xóa nhà xuất bản", MessageBoxButtons.YesNo);

            if (dir == DialogResult.Yes)
            {
                DataTable sach = db.getDataFromTable("SACH");
                for (int i = 0; i < sach.Rows.Count; i++)
                {
                    if (sach.Rows[i][5].ToString() == txtMaNXB.Text)
                    {
                        db.resetValueSach(sach.Rows[i][0].ToString(), "NHAXUATBAN");
                    }
                }

                db.deleteDataFromTable(txtMaNXB.Text, "NHAXUATBAN");

                txtMaNXB.Text = "";
                txtTenNXB.Text = "";

                btnXoaNXB.Enabled = false;
                btnSuaNXB.Enabled = false;
                txtMaNXB.Enabled = false;
                txtTenNXB.Enabled = false;
                btnLuuNXB.Enabled = false;

                DataTable nxb = db.getDataFromTable("NHAXUATBAN");
                nxb.Rows[0].Delete();
                dgv_NhaXuatBan.DataSource = nxb;
            }
        }
        /// <summary>
        /// Save data with add or update action
        /// </summary>
        private void btnLuuNXB_Click(object sender, EventArgs e)
        {
            if (txtTenNXB.Text != "")
            {
                if (btnSuaNXB.Enabled == true)
                {
                    db.updateDataFromTiniObjects(txtMaNXB.Text, txtTenNXB.Text, "NHAXUATBAN");
                }
                else
                {
                    db.addDataToTiniObjects(txtMaNXB.Text, txtTenNXB.Text, "NHAXUATBAN");
                }
                DataTable nxb = db.getDataFromTable("NHAXUATBAN");
                nxb.Rows[0].Delete();
                dgv_NhaXuatBan.DataSource = nxb;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin");
            }

            btnXoaNXB.Enabled = false;
            btnSuaNXB.Enabled = false;
            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = false;
            btnLuuNXB.Enabled = false;

            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
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


        /*===THELOAI===*/

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Bạn có muốn xóa thể loại này?", "Xóa thể loại", MessageBoxButtons.YesNo);

            if (dir == DialogResult.Yes)
            {
                DataTable sach = db.getDataFromTable("SACH");
                for (int i = 0; i < sach.Rows.Count; i++)
                {
                    if (sach.Rows[i][3].ToString() == txtMaTheLoai.Text)
                    {
                        db.resetValueSach(sach.Rows[i][0].ToString(), "THELOAI");
                    }
                }

                db.deleteDataFromTable(txtMaTheLoai.Text, "THELOAI");

                txtMaTheLoai.Text = "";
                txtTenTheLoai.Text = "";

                btnXoaTheLoai.Enabled = false;
                btnSuaTheLoai.Enabled = false;
                txtMaTheLoai.Enabled = false;
                txtTenTheLoai.Enabled = false;
                btnLuuTheLoai.Enabled = false;

                DataTable theloai = db.getDataFromTable("THELOAI");
                theloai.Rows[0].Delete();
                dgv_TheLoai.DataSource = theloai;
            }
        }

        private void dgv_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaTheLoai.Enabled = true;
            btnSuaTheLoai.Enabled = true;

            txtMaTheLoai.Text = dgv_TheLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenTheLoai.Text = dgv_TheLoai.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtTenTheLoai.Enabled = false;

            btnLuuTheLoai.Enabled = false;
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            txtTenTheLoai.Enabled = true;

            btnLuuTheLoai.Enabled = true;
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            txtTenTheLoai.Enabled = true;
            txtTenTheLoai.Text = "";
            txtMaTheLoai.Text = createID(dgv_TheLoai.Rows[dgv_TheLoai.Rows.Count - 2].Cells[0].Value.ToString(), "T", "L");

            btnXoaTheLoai.Enabled = false;
            btnSuaTheLoai.Enabled = false;

            btnLuuTheLoai.Enabled = true;
        }

        private void btnLuuTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text != "")
            {
                if (btnSuaTheLoai.Enabled == true)
                {
                    db.updateDataFromTiniObjects(txtMaTheLoai.Text, txtTenTheLoai.Text, "THELOAI");
                }
                else
                {
                    db.addDataToTiniObjects(txtMaTheLoai.Text, txtTenTheLoai.Text, "THELOAI");
                }
                DataTable theloai = db.getDataFromTable("THELOAI");
                theloai.Rows[0].Delete();
                dgv_NhaXuatBan.DataSource = theloai;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin");
            }

            btnXoaTheLoai.Enabled = false;
            btnSuaTheLoai.Enabled = false;
            txtMaTheLoai.Enabled = false;
            txtTenTheLoai.Enabled = false;
            btnLuuTheLoai.Enabled = false;

            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
        }


        /*===TACGIA===*/

        private void dgv_TacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaTacGia.Enabled = true;
            btnSuaTacGia.Enabled = true;

            txtMaTacGia.Text = dgv_TacGia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenTacGia.Text = dgv_TacGia.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtTenTacGia.Enabled = false;

            btnLuuTacGia.Enabled = false;
        }

        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            txtTenTacGia.Enabled = true;

            btnLuuTacGia.Enabled = true;
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            txtTenTacGia.Enabled = true;
            txtTenTacGia.Text = "";
            txtMaTacGia.Text = createID(dgv_TacGia.Rows[dgv_TacGia.Rows.Count - 2].Cells[0].Value.ToString(), "T", "G");

            btnXoaTacGia.Enabled = false;
            btnSuaTacGia.Enabled = false;

            btnLuuTacGia.Enabled = true;
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Bạn có muốn xóa tác giả này?", "Xóa tác giả", MessageBoxButtons.YesNo);

            if (dir == DialogResult.Yes)
            {
                DataTable sach = db.getDataFromTable("SACH");
                for (int i = 0; i < sach.Rows.Count; i++)
                {
                    if (sach.Rows[i][2].ToString() == txtMaTacGia.Text)
                    {
                        db.resetValueSach(sach.Rows[i][0].ToString(), "TACGIA");
                    }
                }

                db.deleteDataFromTable(txtMaTacGia.Text, "TACGIA");

                txtMaTacGia.Text = "";
                txtTenTacGia.Text = "";

                btnXoaTacGia.Enabled = false;
                btnSuaTacGia.Enabled = false;
                txtMaTacGia.Enabled = false;
                txtTenTacGia.Enabled = false;
                btnLuuTacGia.Enabled = false;

                DataTable tacgia = db.getDataFromTable("TACGIA");
                tacgia.Rows[0].Delete();
                dgv_TacGia.DataSource = tacgia;
            }

        }

        private void btnLuuTacGia_Click(object sender, EventArgs e)
        {
            if (txtTenTacGia.Text != "")
            {
                if (btnSuaTacGia.Enabled == true)
                {
                    db.updateDataFromTiniObjects(txtMaTacGia.Text, txtTenTacGia.Text, "TACGIA");
                }
                else
                {
                    db.addDataToTiniObjects(txtMaTacGia.Text, txtTenTacGia.Text, "TACGIA");
                }
                DataTable tacgia = db.getDataFromTable("TACGIA");
                tacgia.Rows[0].Delete();
                dgv_TacGia.DataSource = tacgia;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin");
            }

            btnXoaTacGia.Enabled = false;
            btnSuaTacGia.Enabled = false;
            txtMaTacGia.Enabled = false;
            txtTenTacGia.Enabled = false;
            btnLuuTacGia.Enabled = false;

            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
        }
    }
}
