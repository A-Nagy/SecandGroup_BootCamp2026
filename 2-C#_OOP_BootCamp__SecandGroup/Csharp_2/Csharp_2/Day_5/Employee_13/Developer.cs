using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Employee_13
{
    class Developer : Employee
    {
        public double HourlyRate { get; set; }
        public double OvertimeHours { get; set; }
        public Developer(string name, double salary, double hourlyRate, double overtimeHours) 
            : base(name, salary)
        {
            HourlyRate = hourlyRate;
            OvertimeHours = overtimeHours;
        }
        public override double GetNetSalary()
        {
            //return base.GetNetSalary() + (HourlyRate * OvertimeHours);
            return base.Salary + (HourlyRate * OvertimeHours);
            //return Salary + (HourlyRate * OvertimeHours);
        }
    }
}
