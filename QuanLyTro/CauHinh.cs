using System;
using System.Data.SQLite;
using System.IO;

namespace QuanLyTro
{
    public static class CauHinh
    {
        //Tên phần mềm
        public static readonly string TenPhanMem = "Quản Lý Trọ";

        //Mutex của phần mềm tránh chạy trùng lặp gây lỗi cho database
        public static readonly string Mutex = "kh0anh-QuanLyTro";
        
        //Class truy vấn cơ sở dữ liệu bằng SQLITE3
        public static SQLiteConnection CSDL;

        //Đường dẫn mặt định của database
        private static readonly string duongDanCSDL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite3");

        public static void init()
        {
            //Kiểm tra database có tồn tại không nếu không thì tạo
            if (File.Exists(duongDanCSDL))
            {
                //Mở kết nối database
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();

                //Tạo các bảng dữ liệu và dữ liệu mặt định nếu không tồn tại
                //using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS test(id INTEGER PRIMARY KEY, name TEXT);", CSDL))
                //{
                //    command.ExecuteNonQuery();
                //}
                //using (var command = new SQLiteCommand("COMMIT;", CSDL))
                //{
                //    command.ExecuteNonQuery();
                //}
            }
            else
            {
                //Mở kết nối database
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();
            }
        }
    }
}
