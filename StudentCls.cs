using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEleven
{
    class StudentCls:PersonCls
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }
        public StudentCls()
        {
            //first constructor
            Person = "";
            program = "";
            year = 0;
            fee = 0;

        }
        public StudentCls(string PersonInput, string AddressInput, string ProgramInput, int YearInput, double FeeInput)
        {
            //second constructor
            Person = PersonInput;
            Address = AddressInput;
            Program = ProgramInput;
            Year = YearInput;
            Fee = FeeInput;



        }
            
    }
}
