using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_LTUD_LeTuanAnh
{
    class Sach
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private string theLoai;
        private int soTrang;
        private string nhaXB;
        private int namXuatBan;
        private int giaBia;
        private string noiDung;
        private bool tinhTrangMuon;

        public Sach(string maSach, string tenSach, string tacGia, string theLoai, int soTrang,string nhaXB, int namXuatBan, int giaBia, string noiDung, bool tinhTrangMuon)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.theLoai = theLoai;
            this.soTrang = soTrang;
            this.nhaXB = nhaXB;
            this.namXuatBan = namXuatBan;
            this.giaBia = giaBia;
            this.noiDung = noiDung;
            this.tinhTrangMuon = tinhTrangMuon;
        }

        public string getMaSach()
        {
            return this.maSach;
        }
        public string getTenSach()
        {
            return this.tenSach;
        }
        public string getMaTacGia()
        {
            return this.tacGia;
        }
        public string getMaTheLoai()
        {
            return this.theLoai;
        }
        public int getSoTrang()
        {
            return this.soTrang;
        }
        public string getMaNXB()
        {
            return this.nhaXB;
        }
        public int getNamXB()
        {
            return this.namXuatBan;
        }
        public int getGiaBia()
        {
            return this.giaBia;
        }
        public string getNoiDung()
        {
            return this.noiDung;
        }
        public bool getTinhTrangMuon()
        {
            return this.tinhTrangMuon;
        }
    }
}
