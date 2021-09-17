using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace date_changer
{
    static class Program
    {

        #region System Time Related
        [DllImport("kernel32.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll")]
        private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;

            public SYSTEMTIME(DateTime value)
            {
                wYear = (short)value.Year;
                wMonth = (short)value.Month;
                wDayOfWeek = (short)value.DayOfWeek;
                wDay = (short)value.Day;
                wHour = (short)value.Hour;
                wMinute = (short)value.Minute;
                wSecond = (short)value.Second;
                wMilliseconds = (short)value.Millisecond;
            }
        }
        #endregion

        [STAThread]
		static void Main(string[] args)
		{
            if (args.Length > 0)
            {
                string argPath = Path.GetFullPath(args[0].Remove(0, 1));
                if (File.Exists(argPath))
                {
                    Process proc = new Process();
                    proc.StartInfo.Verb = "runas";
                    proc.StartInfo.FileName = argPath;
                    try
                    {
                        proc.Start();

                        //date change
                        var argDate = Convert.ToDateTime(args[1].Remove(0, 1));
                        if (argDate != DateTime.Today)
                        {
                            argDate.ToString("MM - dd - yyyy");
                            TimeSpan currentSystemTime = DateTime.Now.TimeOfDay;
                            DateTime newDate = argDate;
                            DateTime newDateTime = newDate.Add(currentSystemTime);
                            SYSTEMTIME newSystemTime = new SYSTEMTIME(newDateTime);
                            SetSystemTime(ref newSystemTime);
                        }

                        proc.WaitForExit();

                        //resync time
                        proc.StartInfo.FileName = "w32tm";
                        proc.StartInfo.Arguments = "/resync";
                        proc.StartInfo.UseShellExecute = false;
                        proc.StartInfo.RedirectStandardOutput = true;
                        proc.StartInfo.CreateNoWindow = true;
                        proc.Start();
                    }
                    catch
                    {
                        // The user refused the elevation.
                        // Do nothing and return directly ...
                        return;
                    }

                    Environment.Exit(1);
                }
                else
                {
                    DialogResult errorMsg = MessageBox.Show("No file to execute in\n" + argPath, "Date Changer");
                    if (errorMsg == DialogResult.OK)
                    {
                        Environment.Exit(1);
                    }
                }
            }
            else if (!SingleInstance.Start())
			{
				SingleInstance.ShowFirstInstance();
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			try
			{
				Form1 mainForm = new Form1();
				Application.Run(mainForm);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			SingleInstance.Stop();
		}
	}
}
