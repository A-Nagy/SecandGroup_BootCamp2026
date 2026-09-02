using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Employee_13
{
     class Accountant : Employee
    {   
        public double Tax { get; set; }
        public Accountant(string name, double salary,double tax ) : base(name, salary)
        {
            Tax = tax;
        }

        public override double GetNetSalary()
        {
            return base.Salary - Tax;
        }
    
        
    }
}
