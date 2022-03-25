using System;
using System.IO;
using System.Windows.Forms;

namespace DIOXIDE
{
    class main
    {
        static void Main(string[] cmd)
        {
            Functions func = new Functions();
            Application.EnableVisualStyles();

            if (cmd.Length == 0)
            {
                if (File.Exists(func.TempPath + "Dioxide."))
                {
                    func.DeleteDioxideEXECache();
                    execute.executeEWP();
                }
                else
                {
                    func.DioxideEXECachCreate();
                    func.DioxideEXECopy();
                    func.DeleteDioxideEXE();
                }
            }
        }
    }
}