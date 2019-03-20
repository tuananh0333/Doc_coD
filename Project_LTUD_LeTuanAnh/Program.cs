using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_LTUD_LeTuanAnh
{
    /// <summary>
    /// đồ án môn học
    ///     LẬP TRÌNH ỨNG DỤNG
    ///         ----||----
    /// Sinh viên:          Lê Tuấn Anh
    /// Mã số sinh viên:    17211TT0300
    /// 
    /// Giảng viên hướng dẫn: cô Phan Thi Phể
    /// mã lớp học phần: 18111CNC107270
    /// </summary>
    static class Program
    {
        //save user login infor
        public static User user;
        //save book info
        public static Sach sach;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
