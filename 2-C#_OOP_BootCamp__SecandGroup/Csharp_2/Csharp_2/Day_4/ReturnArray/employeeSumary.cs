using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_4.ReturnArray
{

     class employeeSumary
    {
        //static void Main(string[] args)
        //{
        //    string[] summary = GetEmployeeSumary("Ahmad" , 2000);
        //    foreach (string item in summary)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}

        static string[] GetEmployeeSumary(string name, double Salary) 
        {
            double annual = Salary * 12;

            string level = Salary >= 15000 ? "High Salary"   :
                           Salary >= 10000 ? "normal Salary" :
                           Salary >= 5000  ? "Low Salary"    : "very Low Salary";

            return new string[] {"EMPLOYEE name   is : " + name,
                                       "EMPLOYEE Salary is : " + Salary,
                                       "EMPLOYEE annual is : " + annual,
                                       "EMPLOYEE Level  is : " + level };
            
        }
        /*
         * ` 
         */
    }
}
