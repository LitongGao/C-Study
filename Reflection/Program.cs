using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Remoting;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectHandle oHandle = Activator.CreateInstance("CollectionPractices", "CollectionPractices.Racer");
            Object p = oHandle.Unwrap();
            Type T = p.GetType();
            PropertyInfo[] pis = T.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                Console.WriteLine(pi.Name);
                if (pi.Name == "FirstName")
                {
                    //pi.Name = "Peter";
                    pi.SetValue(pi, "Peter");
                }

            }

            MethodInfo[] mis = T.GetMethods();
            foreach (MethodInfo mi in mis)
            {
                Console.WriteLine(mi.Name);
            }
            Console.ReadKey();
        }
    }
}
