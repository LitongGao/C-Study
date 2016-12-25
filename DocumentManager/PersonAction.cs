using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public class PersonAction
    {

        public static void SortPerson(Person[] persons)
        {
           Person [] ps = persons;
           Array.Sort(ps,(p1,p2)=>p1.FirstName.CompareTo(p2.FirstName));
           //return ps;
           Array.ForEach(ps, Console.WriteLine);
        }

        public static void ShowPerson(Person[] persons)
        {
           Array.ForEach(persons, Console.WriteLine);
        }
        
        public static void ShowPersonFamilyName(Person[] persons)
        {
            Array.ForEach(persons, p => Console.WriteLine(p.LastName));
        }

        public static Person[] FindPerson(Person[] persons)
        {
            Person[] sPersons = Array.FindAll(persons, p => p.FirstName.StartsWith("p"));
            return sPersons;
        }

    }
}
