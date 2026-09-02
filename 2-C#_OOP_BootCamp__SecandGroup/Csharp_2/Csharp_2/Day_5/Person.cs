using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5
{
    abstract class Person
    {
        string _name;      
        public string Name { get => _name; set => _name = value; }
        public Person(string name)
        {
            Name = name;
        }

        public abstract string GetInfo();
         


    }
}
