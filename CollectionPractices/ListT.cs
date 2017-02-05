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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Wins { get; set; }
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
        public override string Tostring()
        {
            return String.Format("{0}, {1}", FirstName, LastName);
        }

        public string Tostring(string format, IFormatProvider formatProvider)
        {
            switch(format.ToUpper())
            {
                case null:
                case "N":
                    return Tostring();
                case "F":
                    return FirstName;
                case "L":
                    return LastName;
                case "C":
                    return Country;
                case "W":
                    return Wins.ToString();
                default:
                    throw new FormatException(String.Format(formatProvider, "Format {0}, is not support", format));
            }
        }

        public string ToString(string format)
        {
            return Tostring(format, null);
        }
        #endregion
    }
}
