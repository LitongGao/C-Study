using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractices
{
    class RacerAction
    {
        Racer graham = new Racer("Graham111", "Hill", "UK", 6);
        Racer emeron = new Racer("Emerson", "Fitt", "Brazil", 12);
        Racer mario = new Racer("Mario", "Andri", "USA", 12);
        public List<Racer> CreateRacer()
        {
            List<Racer> racerList = new List<Racer>();
            racerList.Add(graham);
            racerList.Add(emeron);
            racerList.Add(mario);
            racerList.Add(new Racer("Peter", "Gao", "China", 20));
            racerList.Add(new Racer("Litong", "Gao", "China"));
            racerList.Insert(0, new Racer());
            return racerList;
        }

        public void ShowRacer()
        {
            foreach (Racer r in CreateRacer())
            {
                Console.WriteLine(r.ToString());
                
            }
            Console.ReadKey();
        }

        public void ShowInputRacer(List<Racer> racers, string format)
        {
            foreach (Racer r in racers)
            {
                Console.WriteLine(r.ToString(format));
                
            }
            Console.ReadKey();
        }


    }
}
