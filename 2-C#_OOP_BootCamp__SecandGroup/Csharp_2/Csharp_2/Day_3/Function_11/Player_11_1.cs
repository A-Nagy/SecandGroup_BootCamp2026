using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_3.Function_11
{
    class Player_11_1
    {
        //static void Main(string[] args)
        //{

        //    //Functions_11_2.EmployeeSalayInfo();

        //    //Functions_11_2.StudentGradeChecker();

        //    //Functions_11_2.BMI_Calcuator();

        //    //  double result =  StaticAdd(5,5);


        //    Console.WriteLine("=== Static Method Call===");
        //    double sum = StaticAdd(10, 20);
        //    Console.WriteLine("Sum number is : "+sum);

        //    Console.WriteLine("=== Instance Method Call===");
        //    Player_11_1 p = new Player_11_1();
        //    double product = p.instanceMultiply(10, 20);
        //    Console.WriteLine("Sum number is : " + product);

        //}
         

        // function To Sum 2 number 
        public static double StaticAdd(double a , double b ) 
        { 
            return a + b;
        }
        // function To Multiply 2 number 
        public double instanceMultiply(double x, double y) 
        {
            return x * y;
        }


        /*
         */

        //public static double EmployeeNetSalary(double Salary, double discounts) 
        //{
        //    double taxes     = Salary * .10;
        //    double ensurance = Salary * .14; 
        //    return Salary - (taxes + ensurance+discounts);
        //}

    }
}
