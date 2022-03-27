using System;
using System.IO;
using System.Windows.Forms;
using static DIOXIDE.Functions;
using static DIOXIDE.execute;

namespace DIOXIDE
{
    class main
    {
        static void Main(string[] cmd)
        {
            Application.EnableVisualStyles();

            if (cmd.Length == 0)
            {
                executeP();
            }
            else
            {
                for (int i = 0; i < cmd.Length; i++)
                {
                    if (cmd[i] == "/P")
                    {
                        execute.executeP();
                    }
                    if (cmd[i] == "/EWP")
                    {
                        execute.executeEWP();
                    }
                    if (cmd[i] == "/help")
                    {
                        MessageBox.Show("/P Peaceful" + Environment.NewLine + "/EWP EnabledWarningPeaceful", "help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}