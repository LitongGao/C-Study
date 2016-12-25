using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAccount();
            RunPerson();
           
        }

        public static void RunDocumentManager()
        {
            DocumentManager<Document> dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("A", "a is here"));
            dm.AddDocument(new Document("B", "b is here"));
            dm.DisplayAllDocument();
            if (dm.IsDocumentAvailable)
            {
                Document d = dm.GetDocument();
                Console.WriteLine(d.Content);
                dm.DisplayAllDocument();
            }
            int i = 5;
            int j = 6;
            DocumentManager<Document>.Swap(ref i, ref j);
            Console.WriteLine(i);
            Console.ReadKey();
            DocumentManager<int>.x = 5;
        }

        public static void RunAccount()
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("Peter gao", 1500));
            accounts.Add(new Account("rain", 1021));
            accounts.Add(new Account("Lit", 992));
            decimal amount = Algorithm.AccumulateSimple(accounts);
            decimal amountGenerics = Algorithm.Accumulate(accounts);
            decimal amountDelegatePre = Algorithm.AccumulateIf<Account, decimal>(accounts, (a, d) => a.Balance + d, a => a.Balance > 1000);
            decimal amountDelegate = Algorithm.AccumulateDelegate<Account, decimal>(accounts, delegate(Account a, decimal d) { return a.Balance + d; });
            Console.WriteLine("1 is {0}\n,the second is {1}",amount,amountGenerics);
            Console.WriteLine(amountDelegate);
            Console.WriteLine(amountDelegatePre);
            Console.ReadKey();
        }

        public static void RunPerson()
        {
            Person[] persons = {
            new Person("peter","gao"),
            new Person("rain", "hig"),
            new Person("lt","xiong"),
            new Person("p","")
            };
            Console.WriteLine("sort person================");
            //Console.WriteLine(PersonAction.SortPerson(persons));
            PersonAction.SortPerson(persons);
            Console.WriteLine("show person================");
            PersonAction.ShowPerson(persons);
            Console.WriteLine("show lastname================");
            PersonAction.ShowPersonFamilyName(persons);
            Console.WriteLine("find person================");
            Console.WriteLine(PersonAction.FindPerson(persons));
            Console.ReadKey();

        }
    }
}
