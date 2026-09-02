using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_4.DashBoardNewVirson
{
     class EmployeeClass
    {
        public double GetAnnualSalary(double monthlySalary)
        {
            return monthlySalary * 12;
        }
        public string GetSalaryLevel(double monthlySalary)
        {
            return (monthlySalary >= 15000) ? "High Salary" :
                     (monthlySalary >= 10000) ? "normal Salary" :
                     (monthlySalary >= 5000) ? "Low Salary" : "very Low Salary";
        }
        public void PrintEmployeePaner()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Task 1: Employee Salary Info");
            Console.WriteLine("===============================");
        }
        public string[] GetEmployeeSummary(string employeeName, double monthlySalary)
        {
            return new string[] {  "Employee Name: "  + employeeName  ,
                                   "Monthly Salary: " + monthlySalary ,
                                   "Annual Salary: "  + GetAnnualSalary(monthlySalary) ,
                                   "Salary Level "    + GetSalaryLevel(monthlySalary)      };

        }
    }
}
