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
            if (!File.Exists(duongDanCSDL))
            {
                //Mở kết nối database
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();

                string lenhThemCSDL = @"
BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS ""DienNuoc"" (
	""Ma""	TEXT NOT NULL,
	""NgayTao""	TEXT NOT NULL,
	""SoDien""	INTEGER NOT NULL,
	""SoNuoc""	INTEGER NOT NULL,
	""GiaDien""	INTEGER NOT NULL,
	""GiaNuoc""	INTEGER NOT NULL,
	""DienNuocCu""	TEXT,
	""Xoa""	INTEGER NOT NULL,
	FOREIGN KEY(""DienNuocCu"") REFERENCES ""DienNuoc""(""Ma""),
	PRIMARY KEY(""Ma"")
);
CREATE TABLE IF NOT EXISTS ""HopDong"" (
	""Ma""	TEXT NOT NULL,
	""NgayBatDau""	TEXT NOT NULL,
	""NgayKetThuc""	TEXT NOT NULL,
	""GiaThue""	INTEGER NOT NULL,
	""TienCoc"" INTEGER NOT NULL,
	""SoNguoiO"" INTEGER NOT NULL,
	""MaKhachHang""	INTEGER NOT NULL,
	""Xoa""	INTEGER NOT NULL,
	FOREIGN KEY(""MaKhachHang"") REFERENCES ""KhachHang""(""Ma""),
	PRIMARY KEY(""Ma"")
);
CREATE TABLE IF NOT EXISTS ""KhachHang"" (
	""Ma""	TEXT NOT NULL,
	""HoVaTen""	TEXT NOT NULL,
	""DiaChi""	TEXT NOT NULL,
	""GioiTinh""	TEXT NOT NULL,
	""NgaySinh""	TEXT NOT NULL,
	""SDT""	TEXT NOT NULL,
	""SoCCCD""	TEXT NOT NULL,
	""GhiChu""	TEXT NOT NULL,
	""Xoa""	INTEGER NOT NULL,
	PRIMARY KEY(""Ma"")
);
CREATE TABLE IF NOT EXISTS ""NhaTro"" (
	""Ma""	TEXT NOT NULL,
	""Ten""	TEXT NOT NULL,
	""SoLuongPhong""	INTEGER NOT NULL,
	""DiaChi""	TEXT NOT NULL,
	""GhiChu""	TEXT NOT NULL,
	""Xoa""	INTEGER NOT NULL,
	PRIMARY KEY(""Ma"")
);
CREATE TABLE IF NOT EXISTS ""PhuPhi"" (
	""Ma""	TEXT NOT NULL,
	""Ten""	TEXT NOT NULL,
	""Gia""	INTEGER NOT NULL,
	""Xoa""	INTEGER NOT NULL,
	PRIMARY KEY(""Ma"")
);
CREATE TABLE IF NOT EXISTS ""KhachVaPhong"" (
	""MaHopDong""	TEXT NOT NULL,
	""MaKhach""	TEXT NOT NULL,
	""Xoa""	INTEGER NOT NULL,
	FOREIGN KEY(""MaHopDong"") REFERENCES ""HopDong""(""Ma""),
	FOREIGN KEY(""MaKhach"") REFERENCES ""KhachHang""(""Ma""),
	PRIMARY KEY(""MaHopDong"",""MaKhach"")
);
CREATE TABLE IF NOT EXISTS ""Phong"" (
	""NhaTro""	TEXT NOT NULL,
	""MaPhong""	TEXT NOT NULL,
	""Gia""	INTEGER NOT NULL,
	""ToiDa""	INTEGER NOT NULL,
	""PhuPhi""	INTEGER NOT NULL,
	""DienNuoc""	TEXT NOT NULL,
	""TrangThai""	TEXT NOT NULL,
	""HopDong""	TEXT,
	""GhiChu""	TEXT NOT NULL,
	""Xoa""	INTEGER NOT NULL,
	FOREIGN KEY(""NhaTro"") REFERENCES ""NhaTro""(""Ma""),
	PRIMARY KEY(""MaPhong"",""NhaTro"")
);
CREATE TABLE IF NOT EXISTS ""PhuPhiVaPhong"" (
	""MaTro""	TEXT NOT NULL,
	""MaPhong""	TEXT NOT NULL,
	""MaPhuPhi""	TEXT NOT NULL,
	FOREIGN KEY(""MaPhuPhi"") REFERENCES ""PhuPhi""(""Ma""),
	FOREIGN KEY(""MaTro"") REFERENCES ""Phong""(""NhaTro""),
	FOREIGN KEY(""MaPhong"") REFERENCES ""Phong""(""MaPhong""),
	PRIMARY KEY(""MaPhong"",""MaPhuPhi"",""MaTro"")
);
CREATE TABLE IF NOT EXISTS ""ThanhToan"" (
	""Ma""	TEXT NOT NULL,
	""NgayTao""	TEXT NOT NULL,
	""HopDong""	TEXT NOT NULL,
	""TongSoTien""	INTEGER NOT NULL,
	""TienPhong""	INTEGER NOT NULL,
	""TongTienPhuPhi""	INTEGER NOT NULL,
	""TongTienDienNuoc""	INTEGER NOT NULL,
	""MaDienNuoc""	INTEGER NOT NULL,
	""TrangThai""	TEXT NOT NULL,
	""GhiChu""	TEXT NOT NULL,
	""Xoa""	INTEGER NOT NULL,
	FOREIGN KEY(""HopDong"") REFERENCES ""HopDong""(""Ma""),
	FOREIGN KEY(""MaDienNuoc"") REFERENCES ""DienNuoc""(""Ma""),
	PRIMARY KEY(""Ma"")
);
CREATE TABLE IF NOT EXISTS ""CauHinh"" (
	""Ten""	TEXT NOT NULL,
	""CauHinh""	TEXT NOT NULL,
	PRIMARY KEY(""Ten"")
);
INSERT INTO ""CauHinh"" VALUES ('GiaDien','3000');
INSERT INTO ""CauHinh"" VALUES ('GiaNuoc','9000');
COMMIT;
";
                using (SQLiteCommand truyVan = new SQLiteCommand(lenhThemCSDL, CSDL))
                {
                    truyVan.ExecuteNonQuery();
                }
            }
            else
            {
                //Mở kết nối cơ sở dữ liệu
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();
            }

			string selectquery = "SELECT * FROM NhaTro";
			using (SQLiteCommand cmd = new SQLiteCommand(selectquery, CSDL))
			{
				using (SQLiteDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Console.WriteLine($"ID: {reader["Ma"]}");
					}
				}
			}

        }
    }
}
