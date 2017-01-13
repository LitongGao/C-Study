using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    delegate void Printer(string s);
    public class Anonymous
    {
        string output = "HelloWorld!";

        public static void ShowInfo()
        {
            Printer p = delegate (string s) { Console.WriteLine(s); };
            p("anonyous test for 2.0");
            Printer p2 = new Printer(PriterWold);
            p2("anonyous test for 1.0");
        }

        public static void PriterWold(string s)
        {
            Console.WriteLine(s);
        }
    }
}
