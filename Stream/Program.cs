using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream
{
    class Program
    {
        static string filePath = @"C:\ProgramData\Demandforce\Sync Client\Logs\DFLinkClient_Log.log";
        static string filePath2 = @"E:\Logs\DFLinkClient_Log.log";
        static void Main(string[] args)
        {
            ReadFileByFileStream();
            ReadFileByStreamReader();
            Console.ReadKey();
        }

        public static void ReadFileByStreamReader()
        {
            byte[] byData = new byte[100];
            char[] charData = new char[1000];
            StreamReader sr = new StreamReader(filePath, Encoding.Default);
            String line;
            sr.Read(charData, 0, 390);
            Console.WriteLine(charData);
            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line.ToString());
            }
        }
        public static void ReadFileByFileStream()
        {
            byte[] byData = new byte[100];
            char[] charData = new char[100];
            FileStream file = new FileStream(filePath2, FileMode.Open);
            file.Seek(0, SeekOrigin.Begin);
            file.Read(byData, 0, 100);
            Decoder d = Encoding.Default.GetDecoder();
            d.GetChars(byData, 0, byData.Length, charData, 0);
            Console.WriteLine(charData);
            file.Close();
        }
    }
}
