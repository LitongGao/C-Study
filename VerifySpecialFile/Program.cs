using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VerifySpecialFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //VerifySpecialFileIsExist("Pearl.Plugins.Sync.dl");
            IOAction io = new IOAction();
            IOAction.CopyFile(@"E:\software\UIAutomationt\UIAutomationt", @"E:\Logs\copy");
            //IOAction.RemoveFile(@"E:\Logs", "*.txt");
            Console.ReadKey();
        }

        public static bool VerifySpecialFileIsExist(string fileName)
        {
            string filePath = @"C:\Intuit\Demandforce\Sync Client\DFLinkClient";
            string fileNamePath = Path.Combine(filePath, fileName);
            if (!File.Exists(fileNamePath))
            {
                Console.WriteLine("The test file [{0}] does not exist", fileName);
                return false;
            }
            Console.WriteLine("The test file [{0}] does exist", fileName);
            return true;
        }
    }
}
