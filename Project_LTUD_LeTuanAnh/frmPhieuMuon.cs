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
    /// FORM PHIEU MUON
    /// Author: Le Tuan Anh
    /// </summary>
    public partial class frmPhieuMuon : Form
    {
        DB db = new DB();

        string selectedPhieuID = "";
        string selectedSVID = "";
        string selectedSachID = "";

        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load form, format list view and other controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            lstPhieuMuon.Columns.Add("Mã phiếu", 100);
            lstPhieuMuon.Columns.Add("Tên sinh viên", 100);
            lstPhieuMuon.Columns.Add("Tên sách", 100);
            lstPhieuMuon.Columns.Add("Ngày mượn", 100);
            lstPhieuMuon.View = View.Details;
            lstPhieuMuon.FullRowSelect = true;
            lstPhieuMuon.GridLines = true;
            getDataFromPhieuMuon();
            btnTraSach.Enabled = false;

            cboTimPhieuMuon.Items.Add("Tên Sinh Viên");
            cboTimPhieuMuon.Items.Add("Tên Sách");
            cboTimPhieuMuon.SelectedIndex = 0;

            lblTenSach.Text = "";
            lblTenSach.AllowDrop = true;
            lblTenSV.Text = "";
            lblNgayMuon.Text = "";
        }

        /// <summary>
        /// load data from PHIEUMUON to listview
        /// </summary>
        private void getDataFromPhieuMuon()
        {
            DataTable phieuMuon = db.getDataFromTable("PHIEUMUON");

            for (int i = 1; i < phieuMuon.Rows.Count; i++)
            {
                DataTable sv = db.findSinhVienByID(phieuMuon.Rows[i][1].ToString());
                DataTable sach = db.findSachByID(phieuMuon.Rows[i][2].ToString());

                string maPhieu = phieuMuon.Rows[i][0].ToString();
                string tenSV = sv.Rows[0][2].ToString();
                string tenSach = sach.Rows[0][1].ToString();
                string ngayMuon = phieuMuon.Rows[i][3].ToString().Split(' ')[0];

                ListViewItem item = new ListViewItem(maPhieu);
                item.SubItems.Add(tenSV);
                item.SubItems.Add(tenSach);
                item.SubItems.Add(ngayMuon);
                lstPhieuMuon.Items.Add(item);
            }
        }

        /// <summary>
        /// load data from selected rows to field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPhieuMuon.SelectedItems.Count > 0)
            {
                selectedPhieuID = lstPhieuMuon.SelectedItems[0].SubItems[0].Text;
                DataTable pm = new DataTable();
                

                string tenSach = lstPhieuMuon.SelectedItems[0].SubItems[2].Text;
                string tenSV = lstPhieuMuon.SelectedItems[0].SubItems[1].Text;
                string ngayMuon = lstPhieuMuon.SelectedItems[0].SubItems[3].Text;

                lblTenSach.Text = tenSach;
                lblTenSV.Text = tenSV;
                lblNgayMuon.Text = ngayMuon;

                btnTraSach.Enabled = true;
            }
        }

        /// <summary>
        /// click to delete phieuMuon and update status to SinhVien and Book belongs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            DataTable pm = db.findPhieuByID(selectedPhieuID);
            string svID = pm.Rows[0][1].ToString();
            DataTable sv = db.findSinhVienByID(svID);
            int tinhTrangSV = Convert.ToInt32(sv.Rows[0][5].ToString());
            string sachID = pm.Rows[0][2].ToString();

            db.updateTinhTrangSach(sachID, 0);
            db.updateTinhTrangSinhVien(svID, (tinhTrangSV - 1));

            db.deleteDataFromTable(selectedPhieuID, "PHIEUMUON");

            MessageBox.Show("trả sách thành công");
            lstPhieuMuon.Items.Clear();
            getDataFromPhieuMuon();

            lblTenSach.Text = "";
            lblTenSV.Text = "";
            lblNgayMuon.Text = "";

            btnTraSach.Enabled = false;
        }

        /// <summary>
        /// find PhieuMuon by book name or student name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimPhieuMuon_Click(object sender, EventArgs e)
        {
            if (cboTimPhieuMuon.SelectedIndex == 0)
            {
                DataTable phieuMuon = db.findPhieuByStudentName(txtTimPhieuMuon.Text);
                lstPhieuMuon.Items.Clear();
                for (int i = 0; i < phieuMuon.Rows.Count; i++)
                {
                    DataTable sv = db.findSinhVienByID(phieuMuon.Rows[i][1].ToString());
                    DataTable sach = db.findSachByID(phieuMuon.Rows[i][2].ToString());

                    string maPhieu = phieuMuon.Rows[i][0].ToString();
                    string tenSV = sv.Rows[0][2].ToString();
                    string tenSach = sach.Rows[0][1].ToString();
                    string ngayMuon = phieuMuon.Rows[i][3].ToString().Split(' ')[0];

                    ListViewItem item = new ListViewItem(maPhieu);
                    item.SubItems.Add(tenSV);
                    item.SubItems.Add(tenSach);
                    item.SubItems.Add(ngayMuon);
                    lstPhieuMuon.Items.Add(item);
                }
            }
            else
            {
                DataTable phieuMuon = db.findPhieuByBookName(txtTimPhieuMuon.Text);
                lstPhieuMuon.Items.Clear();
                for (int i = 0; i < phieuMuon.Rows.Count; i++)
                {
                    DataTable sv = db.findSinhVienByID(phieuMuon.Rows[i][1].ToString());
                    DataTable sach = db.findSachByID(phieuMuon.Rows[i][2].ToString());

                    string maPhieu = phieuMuon.Rows[i][0].ToString();
                    string tenSV = sv.Rows[0][2].ToString();
                    string tenSach = sach.Rows[0][1].ToString();
                    string ngayMuon = phieuMuon.Rows[i][3].ToString().Split(' ')[0];

                    ListViewItem item = new ListViewItem(maPhieu);
                    item.SubItems.Add(tenSV);
                    item.SubItems.Add(tenSach);
                    item.SubItems.Add(ngayMuon);
                    lstPhieuMuon.Items.Add(item);
                }
            }
        }
    }
}
