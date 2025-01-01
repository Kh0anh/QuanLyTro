using QuanLyTro.Forms;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
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
            //Kiểm tra xem phần mềm có đang chạy nếu có thì tìm và kích hoạt cửa số phần mềm và thoát phần mềm hiện tại
            using (Mutex mutex = new Mutex(false, CauHinh.Mutex, out bool createdNew))
            {
                if (!createdNew)
                {
                    Process currentProcess = Process.GetCurrentProcess();
                    Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);

                    foreach (var process in processes)
                    {
                        if (process.Id != currentProcess.Id)
                        {
                            IntPtr hWnd = process.MainWindowHandle;
                            if (hWnd != IntPtr.Zero)
                            {
                                ShowWindow(hWnd, SW_RESTORE);
                                SetForegroundWindow(hWnd);
                            }
                            break;
                        }
                    }

                    return;
                }
            }

            CauHinh.init(); //Tải cấu hình

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Tạo và tải form chính
            _FormMain = new FormMain();
            Application.Run(_FormMain);
        }

        //Form chính để static để truy vấn khi đa luồng hoặc ...
        public static FormMain _FormMain { get; set; }

        // Import các hàm từ Windows API
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;
    }
}
