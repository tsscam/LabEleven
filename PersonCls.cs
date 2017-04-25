using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEleven
{
    abstract class PersonCls
    {
        private string person;
        private string address;

        public string Person
        {
            get
            {
                return person;
            }

            set
            {
                person = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public PersonCls()
        {
            person = "";
            address = "";

            }
        public PersonCls (string PersonInput, string AddressInput)
        {
            person = PersonInput;
            address = AddressInput;

            Console.WriteLine(Person + "," + Address + ".");
        }
    }
}
