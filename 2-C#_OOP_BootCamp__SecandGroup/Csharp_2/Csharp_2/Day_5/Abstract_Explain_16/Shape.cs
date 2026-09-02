using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Abstract_Explain_16
{
    abstract class Shape
    {
        abstract public double GetArea();

        public void Display() 
        {
            Console.WriteLine("It's The Shape");
        }
    }
}
