using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        delegate string DelegateTest(string val);
        delegate double DoubleOp(double x);
        static void Main(string[] args)
        {
            DoubleOp multByTwo = val => val * 2;
            DoubleOp squre = val => val * val;
            DoubleOp[] operations = { multByTwo, squre };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]", i);
                ProcessAndDisplay(operations[i], 2.0);
                ProcessAndDisplay(operations[i], 7.94);
                ProcessAndDisplay(operations[i], 1.414);

            }
            Console.ReadKey();
        }

        public static void InvokeDel()
        {
            DoubleOp[] operations =
            {
                MathsOperations.MultiplyByTwo,
                MathsOperations.Squre
            };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]", i);
                ProcessAndDisplay(operations[i], 2.0);
                ProcessAndDisplay(operations[i], 7.94);
                ProcessAndDisplay(operations[i], 1.414);

            }
        }
        static void ProcessAndDisplay(DoubleOp ops,double x)
        {
            double result = ops(x);
            Console.WriteLine("Value is {0}, result is {1}", x, result);
        }
        public static void TestDel()
        {
            string mid = ", middle part,";
            DelegateTest anonDel = delegate(string param)
            {
                param += mid;
                param += " and this was added to the string";
                return param;
            };
            DelegateTest anotherDel = param =>
            {
                param += mid;
                param += " and this was added to the string";
                return param;
            };
            Console.WriteLine(anonDel("Start of string"));
            Console.WriteLine(anotherDel("Another of string "));
            Console.ReadKey();
        }
    }
}
