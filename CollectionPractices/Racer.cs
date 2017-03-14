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
        //Field, Properties
        #region
        private string firstName;
        private string lastName;
        private string country;
        private int wins;
        public string FirstName { get { return firstName; }  }
        public string LastName { get { return lastName; }  }
        public string Country { get {return country;} set {country = value;} }
        public int Wins { get { return wins; } set { wins = value; } }
        #endregion
        public Racer(string firstname, string lastname, string country, int wins)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.country = country;
            this.wins = wins;
        }

        public Racer(string firstname, string lastname, string country)
            :this(firstname, lastname, country, 0){}    

        public Racer()
            :this(String.Empty, string.Empty, String.Empty){}

        //Method
        #region
        public override string ToString()
        {
            return String.Format("{0}, {1}", FirstName, LastName);
        }

        public string ToString(string format)
        {
            return ToString(format, null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format.ToUpper())
            {
                case null:
                case "N":
                    return ToString();
                case "F":
                    return FirstName;
                case "L":
                    return LastName;
                case "C":
                    return Country;
                case "W":
                    return Wins.ToString();
                case "A":
                    return String.Format("{0}, {1}, Wins:{2}", ToString(), Country, Wins);
                default:
                    throw new FormatException(String.Format(formatProvider, "Format {0}, is not support", format));
            }
        }

        public int CompareTo(Racer other)
        {
            int compare = this.LastName.CompareTo(other.LastName);
            if (compare == 0)
                return this.FirstName.CompareTo(other.FirstName);
            return compare;
        }
        #endregion
    }
}
