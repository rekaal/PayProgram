using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpoyleeLibrary
{
    public class Empolyee
    {
        public int beneFit = 0;
        public int baseSalary = 0;

        public int Benefit
        {
            get
            {
                return beneFit;
            }
            set
            {
                if (value < 0) value = 0;
                else
                    beneFit = value;
            }
        }

        public int BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0) value = 0;
                else
                    baseSalary = value;
            }
        }

        public int Salary
        {
            get
            {
                return BaseSalary + Benefit;
            }
        }
    }
}