using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractices
{
    public class RacerSort: IComparer<Racer>
    {
        public enum CompareType
        {
            FirstName,
            LastName,
            Country,
            Wins
        }

        private CompareType compareType;

        public RacerSort(CompareType type)
        {
            this.compareType = type;
        }

        public int Compare(Racer x, Racer y)
        {
            if (x == null) throw new ArgumentNullException("x");
            if (y == null) throw new ArgumentNullException("y");

            int result;

            switch (compareType)
            {
                case CompareType.FirstName:
                    return x.FirstName.CompareTo(y.FirstName);
                case CompareType.LastName:
                    return x.LastName.CompareTo(y.LastName);
                case CompareType.Country:
                    if ((result = x.Country.CompareTo(y.Country)) == 0)
                        return x.LastName.CompareTo(y.LastName);
                    else
                        return result;
                case CompareType.Wins:
                    return x.Wins.CompareTo(y.Wins);
                default:
                    throw new ArgumentNullException("Invalid compare type");
            }
        }
    }
}
