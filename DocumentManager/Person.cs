using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public class Person
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public Person(string firstname,string lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }

        public override string ToString()
        {
            return this.FirstName+" "+this.LastName;
        }
    }
}
