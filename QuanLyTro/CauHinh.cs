using System;
using System.Data.SQLite;
using System.IO;

namespace QuanLyTro
{
    public static class CauHinh
    {
        public static readonly string TenPhanMem = "Quản Lý Trọ";
        public static SQLiteConnection CSDL;

        private static readonly string duongDanCSDL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite3");

        public static void init()
        {
            if (File.Exists(duongDanCSDL))
            {
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();

                using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS test(id INTEGER PRIMARY KEY, name TEXT);", CSDL))
                {
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();
            }
        }
    }
}
