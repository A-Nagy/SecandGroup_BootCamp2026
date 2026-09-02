using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_4.SecandVersionCalc
{
     class MainClass
    {
        //static void Main(string[] args)
        //{
        //    double[] parmaters = new double[3];
        //    do
        //    {
        //        parmaters= WelcomeScreen();
        //        switch (parmaters[0])
        //        {
        //            case 1:
        //                PrintResult(Add(parmaters[1], parmaters[2]).ToString());
        //                break;
        //            case 2:
        //                PrintResult(sub(parmaters[1], parmaters[2]).ToString());
        //                break;
        //            case 3:
        //                PrintResult(multi(parmaters[1], parmaters[2]).ToString());
        //                break;
        //            case 4:
        //                PrintResult(divid(parmaters[1], parmaters[2]).ToString());
        //                break;
        //            case 5:
        //                PrintResult("Exit...");
        //                break;
        //            default:
        //                PrintResult("Invalid Number");
        //                break;
        //        }
        //    } while (parmaters[0] != 5);
        //}
        static double Add(double num1, double num2) 
        {
            return num1 + num2;
        }
        static double sub(double num1, double num2)
        {
            return num1 - num2;
        }
        static double multi(double num1, double num2)
        {
            return num1 * num2;
        }
        static double divid(double num1, double num2)
        {
            return num1 / num2;
        }
        static double[] WelcomeScreen()
        {
            double num1, num2;
            int ch;
            Console.WriteLine("pls Choose The Oprator Number:\n1.+ \n2.- \n3.X \n4.÷ \n5.Exit...");
            ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("pls enter First Number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pls enter Sacend Number");
            num2 = Convert.ToDouble(Console.ReadLine());
            return new double[] { ch, num1, num2 }; 
        }
        static void PrintResult(string result) 
        {
            Console.WriteLine(result);
        }
  

    }
}
