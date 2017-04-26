using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            ///please add method
            //ArrayList objectList = new ArrayList();
            //List<int> intList = new List<int>();
            //List<Racer> racerList = new List<Racer>();
            //racerList.Capacity = 10;
            /*
            Racer graham = new Racer("Graham", "Hill", "UK", 6);
            Racer emeron = new Racer("Emerson", "Fitt", "Brazil", 12);
            Racer mario = new Racer("Mario", "Andri", "USA", 12);
            List<Racer> racerList = new List<Racer>();
            racerList.Add(graham);
            racerList.Add(emeron);
            racerList.Add(mario);
            racerList.Add(new Racer("Peter", "Gao", "China", 20));
            racerList.Add(new Racer("Litong", "Gao", "China"));
            racerList.Insert(0, new Racer());
            RacerAction racerA = new RacerAction();
            //racerA.ShowRacer();
            racerA.ShowInputRacer(racerList,"w");
            racerList.Sort(new RacerSort(RacerSort.CompareType.Wins));
            racerA.ShowInputRacer(racerList, "a");
            Console.ReadKey();
            */
            DictTest dt = new DictTest();
            dt.FindMethodForDict();
        }
    }
}
