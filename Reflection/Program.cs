using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Remoting;
using CollectionPractices;
using DelegateBubbleSorter;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            GetObject("CollectionPractices", "Racer");
            Console.ReadKey();
        }

        public static void GetObject()
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
        }

        public static void GetObject(string assemblyName, string className)
        {
            Assembly asm = Assembly.Load(assemblyName);
            Type t = asm.GetType((assemblyName+ '.' + className));           
            Object[] constructParms = new Object[] { "Peter", "Gao", "China" };
            Racer obj = (Racer)Activator.CreateInstance(t,constructParms);
            MethodInfo mi = t.GetMethod("CompareTo");
            Racer test = new Racer();
            object[] parameters = new object[] { test };
            mi.Invoke(obj, BindingFlags.Public, Type.DefaultBinder, parameters, null);
            Console.WriteLine(mi.Name);
            Console.WriteLine(obj.ToString("A"));
        }

        public static void GetDelegate()
        {
            BubbleSorter bs = new BubbleSorter();
            Assembly asm = Assembly.Load("DelegateBubbleSorter");
            Type t = Type.GetType("DelegateBubbleSorter.BubbleSorter");
            BubbleSorter.Comparison method = (BubbleSorter.Comparison)Delegate.CreateDelegate(t, bs, "Sort");
        }
    }
}
