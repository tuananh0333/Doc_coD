using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project_LTUD_LeTuanAnh
{
    class DB
    {
        SqlConnection conn = new SqlConnection();

        /// <summary>
        /// DB constructor
        /// </summary>
        public DB()
        {
            try
            {
                conn.ConnectionString = @"Data Source=ADMIN-PC0209VFT;Initial Catalog=QUAN_LY_THU_VIEN;Integrated Security=True";
                conn.Open();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        /// <summary>
        /// get data from a table in database QUAN_LY_THU_VIEN
        /// </summary>
        /// <param name="tableName">table's name</param>
        /// <returns>a DataTable value</returns>
        public DataTable getDataFromTable(string tableName)
        {
            DataTable dTable = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand("dbo.sp_getDataFromTable", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tableName", tableName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
            return dTable;
        }

        /// <summary>
        /// find staff by their ID
        /// </summary>
        /// <param name="ID">Staff's ID</param>
        /// <returns>a staff row</returns>
        public DataTable getNhanVienByID(string ID)
        {
            DataTable nhanvien = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getNhanVienByID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maso",ID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(nhanvien);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }


            return nhanvien;
        }

        /// <summary>
        /// get object name by ID
        /// tables:
        ///     [TACGIA]
        ///     [THELOAI]
        ///     [NHAXUATBAN]
        /// </summary>
        /// <param name="ID">object's ID</param>
        /// <returns>name of object</returns>
        public string getNameByID(string ID, string tableName)
        {
            string name = "";
            
            DataTable dTable = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand("dbo.sp_getDataFromTable", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tableName", tableName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    if (dTable.Rows[i][0].ToString() == ID)
                    {
                        name = dTable.Rows[i][1].ToString();
                        break;
                    }
                }
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            if (name == "")
            {
                name = "Không xác định";
            }
            return name;
        }

        /// <summary>
        /// delete data from table
        /// </summary>
        /// <param name="ID">object's ID</param>
        /// <param name="tableName">table's name</param>
        /// <returns>an interger</returns>
        public int deleteDataFromTable(string ID, string tableName)
        {
            int quer = 0;

            string sp = "";
            string att = "";

            switch (tableName)
            { 
                case "NHANVIEN":
                    sp = "sp_deleteNhanVien";
                    att = "@maNV";
                    break;

                case "NHAXUATBAN":
                    sp = "sp_deleteNhaXuatBan";
                    att = "@maNXB";
                    break;

                case "SACH":
                    sp = "sp_deleteSach";
                    att = "@maSach";
                    break;

                case "SINHVIEN":
                    sp = "sp_deleteSinhVien";
                    att = "@maSV";
                    break;

                case "TACGIA":
                    sp = "sp_deleteTacGia";
                    att = "@maTG";
                    break;

                case "THELOAI":
                    sp = "sp_deleteTheLoai";
                    att = "@maTheLoai";
                    break;

                case "PHIEUMUON":
                    sp = "sp_deletePhieuMuon";
                    att = "@maPhieu";
                    break;
            }

            try
            {
                SqlCommand command = new SqlCommand(sp, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(att, ID);

                quer = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
            
            return quer;
        }

        /// <summary>
        /// add data to tables
        /// </summary>
        public int addDataToNhanVien(string maNV, string tenDangNhap, string ten, string matKhau)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_addNhanVien", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maNV", maNV);
                command.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@matKhau", matKhau);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        /// <summary>
        /// add data to tables:
        ///     [NHAXUATBAN]
        ///     [TACGIA]
        ///     [THELOAI]
        /// </summary>
        /// <param name="ID">object ID </param>
        /// <param name="name">object name</param>
        /// <param name="tableName">table name</param>
        /// <returns>an Interger</returns>
        public int addDataToTiniObjects(string ID, string name, string tableName)
        {
            int res = 0;

            string sp = "";
            string first_att = "";
            string second_att = "";

            switch (tableName)
            { 
                case "NHAXUATBAN":
                    sp = "sp_addNhaXuatBan";
                    first_att = "@maNXB";
                    second_att = "@tenNXB";
                    break;
                case "TACGIA":
                    sp = "sp_addTacGia";
                    first_att = "@maTG";
                    second_att = "@tenTG";
                    break;
                case "THELOAI":
                    sp = "sp_addTheLoai";
                    first_att = "@maTheLoai";
                    second_att = "@tenTheLoai";
                    break;
            }

            try
            {
                SqlCommand command = new SqlCommand(sp, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(first_att, ID);
                command.Parameters.AddWithValue(second_att, name);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        /// <summary>
        /// add new book to database
        /// </summary>
        /// <param name="maSach"></param>
        /// <param name="tenSach"></param>
        /// <param name="maTG"></param>
        /// <param name="maTheLoai"></param>
        /// <param name="soTrang"></param>
        /// <param name="maNhaXuatBan"></param>
        /// <param name="namXB"></param>
        /// <param name="gia"></param>
        /// <param name="noiDung"></param>
        /// <param name="tinhTrang"></param>
        /// <returns>an Interger</returns>
        public int addDataToSach(string maSach, string tenSach, string maTG, string maTheLoai, int soTrang, string maNhaXuatBan, int namXB, int gia, string noiDung, int tinhTrang)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_addSach", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maSach", maSach);
                command.Parameters.AddWithValue("@tenSach", tenSach);
                command.Parameters.AddWithValue("@maTG", maTG);
                command.Parameters.AddWithValue("@maTheLoai", maTheLoai);
                command.Parameters.AddWithValue("@soTrang", soTrang);
                command.Parameters.AddWithValue("@maNXB", maNhaXuatBan);
                command.Parameters.AddWithValue("@namXB", namXB );
                command.Parameters.AddWithValue("@gia", gia);
                command.Parameters.AddWithValue("@noiDung", noiDung);
                command.Parameters.AddWithValue("@tinhTrang", tinhTrang);


                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        /// <summary>
        /// add new student to database
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="tenDangNhap"></param>
        /// <param name="tenSV"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="diaChi"></param>
        /// <param name="matKhau"></param>
        /// <returns>an Interger</returns>
        public int addDataToSinhVien(string mssv, string tenDangNhap, string tenSV, DateTime ngaySinh, string diaChi, string matKhau)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_addSinhVien", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mssv", mssv);
                command.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@tenSV", tenSV);
                command.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                command.Parameters.AddWithValue("@diaChi", diaChi);
                command.Parameters.AddWithValue("@tinhTrangMuon", 0);
                command.Parameters.AddWithValue("@matKhau", matKhau);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        /// <summary>
        /// add new data to PhieuMuon
        /// </summary>
        /// <param name="maPhieu"></param>
        /// <param name="mssv"></param>
        /// <param name="maSach"></param>
        /// <param name="ngayMuon"></param>
        /// <returns></returns>
        public int addDataToPhieuMuon(string maPhieu, string mssv, string maSach, DateTime ngayMuon)
        {
            int result = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_addPhieuMuon", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maPhieu", maPhieu);
                command.Parameters.AddWithValue("@mssv", mssv);
                command.Parameters.AddWithValue("@maSach", maSach);
                command.Parameters.AddWithValue("@ngayMuon", ngayMuon);

                result = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }

        /// <summary>
        /// update data from tables
        /// </summary>
        public int updateNhanVienName(string maNV,string ten)
        {
            int result = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_updateNhanVien", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maNV", maNV);
                command.Parameters.AddWithValue("@ten", ten);

                result = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        /// <summary>
        /// update username and password of NhanVien
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="tenDangNhap"></param>
        /// <param name="matKhau"></param>
        /// <returns></returns>
        public int updateNhanVienAccount(string maNV, string tenDangNhap, string matKhau)
        {
            int result = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_updateAccNhanVien", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maNV", maNV);
                command.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@matKhau", matKhau);

                result = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        /// <summary>
        /// update data from 3 tables:
        ///     [NHAXUATBAN]
        ///     [TACGIA]
        ///     [THELOAI]
        /// </summary>
        public int updateDataFromTiniObjects(string ID, string name, string tableName)
        {
            int res = 0;

            string sp = "";
            string first_att = "";
            string second_att = "";

            switch (tableName)
            {
                case "NHAXUATBAN":
                    sp = "sp_updateNhaXuatBan";
                    first_att = "@maNXB";
                    second_att = "@tenNXB";
                    break;
                case "TACGIA":
                    sp = "sp_updateTacGia";
                    first_att = "@maTG";
                    second_att = "@tenTG";
                    break;
                case "THELOAI":
                    sp = "sp_updateTheLoai";
                    first_att = "@maTheLoai";
                    second_att = "@tenTheLoai";
                    break;
            }

            try
            {
                SqlCommand command = new SqlCommand(sp, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(first_att, ID);
                command.Parameters.AddWithValue(second_att, name);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        //Sach
        /// <summary>
        /// update book's Information
        /// </summary>
        /// <param name="maSach"></param>
        /// <param name="tenSach"></param>
        /// <param name="maTG"></param>
        /// <param name="maTheLoai"></param>
        /// <param name="soTrang"></param>
        /// <param name="maNhaXuatBan"></param>
        /// <param name="namXB"></param>
        /// <param name="gia"></param>
        /// <param name="noiDung"></param>
        /// <returns></returns>
        public int updateSachInfo(string maSach, string tenSach, string maTG, string maTheLoai, int soTrang, string maNhaXuatBan, int namXB, int gia, string noiDung)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_updateThongTinSach", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maSach", maSach);
                command.Parameters.AddWithValue("@tenSach", tenSach);
                command.Parameters.AddWithValue("@maTG", maTG);
                command.Parameters.AddWithValue("@maTheLoai", maTheLoai);
                command.Parameters.AddWithValue("@soTrang", soTrang);
                command.Parameters.AddWithValue("@maNXB", maNhaXuatBan);
                command.Parameters.AddWithValue("@namXB", namXB);
                command.Parameters.AddWithValue("@gia", gia);
                command.Parameters.AddWithValue("@noiDung", noiDung);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        /// <summary>
        /// update book's status
        /// </summary>
        /// <param name="maSach"></param>
        /// <param name="tinhTrangSach">this book have borrowed or not</param>
        /// <returns></returns>
        public int updateTinhTrangSach(string maSach, int tinhTrangSach)
        {
            int result = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_updateTinhTrangSach", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maSach", maSach);
                command.Parameters.AddWithValue("@tinhTrang", tinhTrangSach);

                result = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        //SinhVien
        public int updateSinhVienInfo(string mssv, string tenSV, DateTime ngaySinh, string diaChi)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_updateThongTinSinhVien", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mssv", mssv);
                command.Parameters.AddWithValue("@tenSV", tenSV);
                command.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                command.Parameters.AddWithValue("@diaChi", diaChi);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        public int updateSinhVienAccount(string mssv, string tenDangNhap, string matKhau)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_SV_thongTinDangNhap", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mssv", mssv);
                command.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@matKhau", matKhau);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        public int updateSinhVienUserName(string mssv, string tenDangNhap)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_SV_doiTenTaiKhoan", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mssv", mssv);
                command.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        public int updateSinhVienPassword(string mssv, string matKhau)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_SV_doiMatKhau", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mssv", mssv);
                command.Parameters.AddWithValue("@matKhau", matKhau);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }
        public int updateTinhTrangSinhVien(string mssv, int tinhTrangMuon)
        {
            int res = 0;

            try
            {
                SqlCommand command = new SqlCommand("sp_updateTinhTrangSV", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mssv", mssv);
                command.Parameters.AddWithValue("@tinhTrangMuon", tinhTrangMuon);

                res = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return res;
        }

        /// <summary>
        /// get object's ID by it's name
        /// tables:
        ///     [NHAXUATBAN]
        ///     [THELOAI]
        ///     [TACGIA]
        /// </summary>
        /// <param name="name">object's name</param>
        /// <param name="tableName">object's table</param>
        /// <returns>object's ID</returns>
        public string getObjectsIDbyName(string name, string tableName)
        {
            string id = "";

            string sp = "";
            string att = "";

            switch (tableName)
            {
                case "NHAXUATBAN":
                    sp = "sp_getID_NXBbyName";
                    att = "@tenNXB";
                    break;
                case "THELOAI":
                    sp = "sp_getID_TheLoaibyName";
                    att = "@tenTheLoai";
                    break;
                case "TACGIA":
                    sp = "sp_getID_TacGiabyName";
                    att = "@tenTacGia";
                    break;
            }

            try
            {
                SqlCommand command = new SqlCommand(sp, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(att, name);

                DataTable tab = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tab);

                id = tab.Rows[0][0].ToString();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return id;
        }

        /// <summary>
        /// 2 functions below:
        /// find student
        ///     - by ID
        ///     - by name
        /// </summary>
        /// <param name="ID">student's ID</param>
        /// <param name="name">student's name</param>
        /// <returns>list student</returns>
        public DataTable findSinhVienByID(string ID)
        {
            DataTable result = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getSinhVienByID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mssv", ID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        public DataTable findSinhVienByName(string name)
        {
            DataTable result = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getSinhVienByName", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenSV", name);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }

        /// <summary>
        /// 3 fucntions below:
        /// find book
        ///     - by ID
        ///     - by name
        ///     - by author's name
        /// </summary>
        /// <param name="ID">book's ID</param>
        /// <param name="name">book's name</param>
        /// <param name="authorName">author's name</param>
        /// <returns>list book</returns>
        public DataTable findSachByID(string ID)
        {
            DataTable result = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getSachByID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maSach", ID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        public DataTable findSachByName(string name)
        {
            DataTable result = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getSachByName", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenSach", name);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        public DataTable findSachByAuthorName(string authorName)
        {
            DataTable result = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getSachByAuthorName", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenTacGia", authorName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }

        public DataTable findPhieuByID(string ID)
        {
            DataTable result = new DataTable();
            
            try
            {
                SqlCommand command = new SqlCommand("sp_getPhieuMuonByID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maPhieu", ID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        public DataTable findPhieuByStudentName(string name)
        {
            DataTable result = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getPhieuMuonBySVname", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenSV", name);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
        public DataTable findPhieuByBookName(string name)
        {
            DataTable result = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("sp_getPhieuMuonByBookName", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenSach", name);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }

        /// <summary>
        /// If user have delete
        ///     NHAXUATBAN
        ///     THELOAI
        ///     TACGIA
        /// of a book, that attribute will return to "khong xac dinh"
        /// </summary>
        /// <param name="id"></param>
        /// <param name="attName"></param>
        /// <returns></returns>
        public int resetValueSach(string id, string attName)
        {
            int result = 0;
            
            string db = "";

            switch (attName)
            { 
                case "NHAXUATBAN":
                    db = "sp_resetNXBSach";
                    break;
                case "THELOAI":
                    db = "sp_resetTheLoaiSach";
                    break;
                case "TACGIA":
                    db = "sp_resetTacGiaSach";
                    break;
            }

            try
            {
                SqlCommand command = new SqlCommand(db, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maSach", id);

                result = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }

            return result;
        }
    }
}
