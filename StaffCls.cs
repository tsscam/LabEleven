using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEleven
{
    class StaffCls:PersonCls
    {
        private string school;
        private double pay;

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }
        public StaffCls()
        {
            //first constructor
            school = "";
            pay = 0;

        }
        public StaffCls(string Person, string AddressInput, string SchoolInput, double PayInput)
        {   //second constructor
            school = SchoolInput;
            pay = PayInput;

        }
        public override string ToString()
        {
            return base.ToString() + Person + "," + Address + "," + School + "," + Pay + "," ;
        }
    }
}
