using QuanLyTro.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTro
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Tạo và tải form chính
            _FormMain = new FormMain();
            Application.Run(_FormMain);
        }

        //Form chính để static để truy vấn khi đa luồng hoặc ...
        public static FormMain _FormMain { get; set; }
    }
}
