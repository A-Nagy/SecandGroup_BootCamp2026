using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Task3PaitentSystem
{
     class Task3PatientSystem
    {/*
          *  Patient System
    - Create an **abstract class** `PatientBase` with:
      - Properties: `Name`, `Height`, `Weight`
      - Abstract Method: `GetBMI()`
    - Create an **interface** `IBodyStatus` with:
      - Method: `GetStatus(double bmi)`
    - Implement a class `Patient` that inherits from `PatientBase` and implements `IBodyStatus`.
      */
        //static void Main(string[] args)
        //{

        //}

    }
    public abstract class PatientBase
    {
        protected PatientBase(string name, double Height, double Weight)
        {
            this.Name = name;
            this.Height = Height;
            this.Weight = Weight;
        }

        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public abstract double GetBMI();

    }
    public interface IBodyStatus
    {
        string GetStatus(double bmi);
    }
    public class Patient : PatientBase, IBodyStatus
    {
        public Patient(string name, double height, double weight) : base(name, height, weight)
        {
        }

        public string GetStatus(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Normal Weight";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }

        public override double GetBMI()
        {
            return Weight / (Height * Height);
        }
    }
}
