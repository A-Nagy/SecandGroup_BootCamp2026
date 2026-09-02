using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Task1EmplyeeSystem
{
     class EmployeeSysstem
    {
//        static void Main(string[] args) 
//        {
//            /*
//             * 
//       Employee System
//- Create an **abstract class** `EmployeeBase` with:
//  - Properties: `Name`, `MonthlySalary`
//  - Abstract Method: `CalculateAnnualSalary()`
//- Create an **interface** `ISalaryLevel` with:
//  - Method: `GetSalaryLevel(double annualSalary)`
//- Implement a class `Employee` that inherits from `EmployeeBase` and implements `ISalaryLevel`.

//             */

//            Employee emp = new Employee("Test",18000);
//            Console.WriteLine(emp.GetSalaryLevel(emp.CalculateAnnualSalary()));

//        }
    }
    public abstract class EmployeeBase 
    {
        string _name;
        double _monthlySalary;
         
        public string Name { get => _name; set => _name = value; }
        public double MonthlySalary { get => _monthlySalary; set => _monthlySalary = value; }
        protected EmployeeBase(string name, double monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }

        public abstract double CalculateAnnualSalary();

    }
    public interface ISalaryLevel 
    {
       string GetSalaryLevel(double annualSalary);
    }
    public class Employee : EmployeeBase, ISalaryLevel
    {
        public Employee(string name, double monthlySalary) : base(name, monthlySalary)
        {
        }

        public override double CalculateAnnualSalary()
        {
            return MonthlySalary * 12;
        }

        public string GetSalaryLevel(double annualSalary)
        {
            return annualSalary >= 180000 ? "High Salary"   :
                   annualSalary >= 120000 ? "Normal Salary" :
                   annualSalary >= 60000  ? "Low Salary"    : "Very Low Salary ";
        }
    }

}
