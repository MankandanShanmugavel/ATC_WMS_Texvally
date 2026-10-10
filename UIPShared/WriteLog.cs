using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UIPShared
{
    public static class WriteLog
    {
        public static void CreateLog(Exception ex)
        {
            StreamWriter sw = File.AppendText(Path.Combine(Environment.CurrentDirectory, "ErrorLog.txt"));
            string dt = "Date :" + DateTime.Now;
            sw.WriteLine("----------------------------------------------");
            sw.WriteLine(dt);
            sw.WriteLine(ex);
            sw.Close();

        }
        public static void AutoSynclog(string msg)
        {
            StreamWriter sw = File.AppendText(Path.Combine(Environment.CurrentDirectory, "AutoSynclog.txt"));
            sw.WriteLine(msg);
            sw.Close();

        }

        public static void FTPError(string msg)
        {
            StreamWriter sw = File.AppendText(Path.Combine(Environment.CurrentDirectory, "FTPError.txt"));
            string dt = "Date :" + DateTime.Now;
            sw.WriteLine("----------------------------------------------");
            sw.WriteLine(dt);
            sw.WriteLine(msg);
            sw.Close();

        }
        public static void FTPLog(string msg)
        {
            StreamWriter sw = File.AppendText(Path.Combine(Environment.CurrentDirectory, "FTPLog.txt"));
            string dt = "Date :" + DateTime.Now;
            sw.WriteLine("----------------------------------------------");
            sw.WriteLine(dt);
            sw.WriteLine(msg);
            sw.Close();

        }
    }
}
