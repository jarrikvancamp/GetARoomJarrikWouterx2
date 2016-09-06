using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.Logger
{
    public class FileLogger : IFileLogger
    {

        public FileLogger()
        {
            FilePath = AssemblyDirectory + @"\Log\";
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            //    File.WriteAllText(Path.Combine(FilePath, "log.txt"), "FileStart");
        }


        private static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        private string Message { get; set; }

        public string FilePath { get; set; }

        public void WriteDetails(List<string> details)
        {
            foreach (var detail in details)
            {
                Message += String.Format(Environment.NewLine + $"{DateTime.Now}: {detail} \n");
            }
        }

        public void WriteDetails(string detail)
        {

            Message += String.Format(Environment.NewLine + $"{DateTime.Now}: {detail} \n");

        }

        public void WriteHeader(string header)
        {
            Message += String.Format($"[{header.ToUpper()}] : ");
        }

        public void WriteToFile()
        {
            using (StreamWriter write = File.AppendText(FilePath + "log.txt"))
            {
                write.WriteLine(Message);
            }

            //File.AppendAllText(Path.Combine(FilePath, "log.txt"), Message);
        }
    }
}
