using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Employee_13
{
    class Manager : Employee
    {
    
        public double Bonus { get; set; }
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public override double GetNetSalary()
        {
            return Bonus + Salary;
        }

    }
}
