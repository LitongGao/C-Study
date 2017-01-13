using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractices
{
    [Serializable]
    public class Racer : IComparable<Racer>,IFormattable
    {
        public Racer(string firstname, string lastname, string country, int wins)
        {
            
        }
    }
}
