using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Room_12
{
     class Room
    {
        /*
      * **Room**
      - Properties: `Length`, `Width`, `Height`
      - Function: `GetVolume()` → calculates room volume
         
         */
        //Fields:
        //Fields are Variables that are declared directly in a class.
        //Fields can be of any type .
        //Fields are used to store data for the class.
         double _length;
         double _width;
         double _height;

        //Properties:
        //Properties are special methods that are used to
        // encapsulate the fields of a class.
        // Properties have a get and set accessor
        // that allows you to
        // get and set the value of the field.
        public double Length
        {
            get { return _length ; }
            set { _length = value <= 0 ? 0 : value; }  
        }
        public double Width 
        {
            get { return _width; }
            set { _width = value <= 0 ? 0 : value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value <= 0 ? 0 : value; }
        }


        //Constructors:
        // Constructors are special methods that are used to
        // initialize objects of a class.
        // Constructors have the same name as the class
        // and do not have a return type.
        public Room(double length, double width , double height) 
        {
            //if (length <= 0 || width <= 0 || height <= 0)
            //{
            //    throw new ArgumentException("Length, Width, and Height must be positive values.");
            //}
            //else
            //{
                Length  = length;
                Width   = width;
                Height  = height;
            //}

        }

        //Functions
        public double GetVolume()
        {
            return Length * Width ;
        }

    }
}
