using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Review
{/*
- *Abstraction*  Employee class is abstract and hides implementation details using abstract method AnnualSalary()
- *Encapsulation*Private fields (name, salary, etc.) with public properties (getters/setters) 
- *Inheritance*  EmployeeBasic and EmployeeHourly inherit from Employee 
- *Polymorphism* AnnualSalary() is overridden differently in each derived class.
                 Base class reference holds derived class objects
  */
    class Review
    {
        //static void Main(string[] args)
        //{
 
        //}
    }

    public abstract class Employee 
    {
       private string name;
       private double salary;

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public abstract double AnnualSalary();
      
    }
    public class EmployeeBasic : Employee
    {
        double commission;
        public EmployeeBasic(string name, double salary, double commission ) : base(name, salary)
        {
            Commission = commission;
        }

        public double Commission { get => commission; set => commission = value; }

        public override double AnnualSalary()
        {
            return Commission + (Salary*12);
        }
    }
    public class EmployeeHourly : Employee
    {
        private double overTime;

        public EmployeeHourly(string name, double salary, double overTime ) : base(name, salary)
        {
            OverTime = overTime;
        }

        public double OverTime { get => overTime; set => overTime = value; }

        public override double AnnualSalary()
        {
           return OverTime + (Salary*12);
        }
    }

}
