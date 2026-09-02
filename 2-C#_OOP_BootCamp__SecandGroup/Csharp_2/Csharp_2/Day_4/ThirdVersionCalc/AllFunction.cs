using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_4.ThirdVersionCalc
{
     class AllFunction
    {
        public  double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public  double sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public  double multi(double num1, double num2)
        {
            return num1 * num2;
        }
        public  double divid(double num1, double num2)
        {
            return num1 / num2;
        }
        public  double[] WelcomeScreen()
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
        public  void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
