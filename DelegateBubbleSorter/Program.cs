using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBubbleSorter
{
    class Program
    {
        delegate bool Comparison(object x,object y);
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("Bugs Bu",20000),
                new Employee("Litong Gao",21000),
                new Employee("Peter X", 30000),
                new Employee("Rain P", 34000),
                new Employee("Ivory Xiong", (decimal)36000.12)
            };

            BubbleSorter.Sort(employees, Employee.CompareSalary);

            foreach (var employ in employees)
            {
                Console.WriteLine(employ);
            }
            Console.ReadKey();
        }
    }
}
