using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Abstract_Explain_16
{
     class Rectangle :Shape
    {
       

        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double GetArea() 
        {
            return Height * Width;
        } 
    }
}
