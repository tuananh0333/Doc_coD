using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_LTUD_LeTuanAnh
{
    class SinhVien : User
    {
        private string ngaySinh;
        private string diaChi;
        private int tinhTrangMuon;

        public SinhVien(string ID, string userName, string name , string ngaySinh, string diaChi, int tinhTrangMuon, string password)
            : base(ID,userName,name,password)
        {
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.tinhTrangMuon = tinhTrangMuon;
        }

        public string getNgaySinh()
        {
            return this.ngaySinh;
        }

        public string getDiaChi()
        {
            return diaChi;
        }

        public void muonSach()
        {
            this.tinhTrangMuon++;
        }
        public void traSach()
        {
            this.tinhTrangMuon--;
        }
        public int getTinhTrangMuon()
        {
            return this.tinhTrangMuon;
        }
        public void setTinhTrangMuon(int ttMuon)
        {
            this.tinhTrangMuon = ttMuon;
        }
    }
}
