using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractices
{
    public class DictTest
    {
        Dictionary<string, string> d1 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        Dictionary<string, string> d2 = new Dictionary<string, string>();

        public void FindMethodForDict()
        {
            d1.Add("txt", "notepad.exe");
            d1.Add("bmp", "paint.exe");
            d1.Add("dib", "paint.exe");
            d1.Add("rtf", "wordpad.exe");
            d2.Add("txt", "notepad.exe");
            d2.Add("bmp", "paint.exe");
            d2.Add("dib", "paint.exe");
            d2.Add("rtf", "wordpad.exe");
            bool isHasd1 = d1.ContainsKey("TXT");
            bool isHasd2 = d2.ContainsKey("TXT");
            Console.WriteLine("Result for d1:{0} and d2:{1}",isHasd1,isHasd2);
            Console.ReadKey();
        }
    }
}
