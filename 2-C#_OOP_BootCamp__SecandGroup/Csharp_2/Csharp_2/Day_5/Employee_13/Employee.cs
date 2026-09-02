using System;

namespace Csharp_2.Day_5.Employee_13
{
     class Employee:Person ,IPrintable
    {
        /*
         * 2. **Employee**
            - Properties: `Name`, `Salary`
             - Functions:
             - `CalculateAnnualSalary()` → returns yearly salary
             - `GetAnnualSalaryLevel(double annualSalary)` → same but receives salary as a parameter
             - `GetAnnualSalaryLevel()` → returns salary level based on computed annual salary
         */

        ////Fields
   
        private double _salary;

        //properties
 
        public double Salary
        {
          get => _salary ;
          set => _salary = value<2000?2500:value;
        }

        //Constructor
        public Employee(string name , double salary) : base(name)
        {
            
            Salary = salary;
        }

        public virtual double GetNetSalary() 
        {
            return Salary;
        }

        public override string GetInfo()
        {
             return $"Employee Name : {Name} \n" +
                    $"Employee Salary : {Salary} \n" +
                    $"Employee Net Salary : {GetNetSalary()}\n ";
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Employee Name : {Name} \n" +
                              $"Employee Salary : {Salary} \n" +
                              $"Employee Net Salary : {GetNetSalary()}\n ");
        }










        ////Functions
        //// ✅ الطريقة الثانية: تعتمد على الخصائص الداخلية للكائن
        //public double CalculateAnnualSalary()
        //{
        //    return Salary * 12;
        //}
        //public string GetAnnualSalaryLevel()
        //{
        //    double annualSalary = CalculateAnnualSalary();
        //    if (annualSalary < 30000)
        //    {
        //        return "Low";
        //    }
        //    else if (annualSalary >= 30000 && annualSalary < 60000)
        //    {
        //        return "Medium";
        //    }
        //    else
        //    {
        //        return "High";
        //    }
        //}

        //// ✅ الطريقة الاولي: تعتمد على قيمة تمرر لها (parameter)
        //public string GetAnnualSalaryLevel(double annualSalary)
        //{
        //    if (annualSalary < 30000)
        //    {
        //        return "Low";
        //    }
        //    else if (annualSalary >= 30000 && annualSalary < 60000)
        //    {
        //        return "Medium";
        //    }
        //    else
        //    {
        //        return "High";
        //    }
        //}
        //public double CalculateAnnualSalary(double salary)
        //{
        //    return salary * 12;
        //}
    }
}
