using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Patient_15
{
    internal class Patient : Person,IPrintable
    {/*
      * **Patient**
        - Properties: `Name`, `Height`, `Weight`
        - Functions:
        - `GetBMI()` → calculates Body Mass Index
         - `GetBodyStatus()` → returns weight classification

      */
        //Fields
       
         double _height;
         double _weight;
        //Properties
     
        public double Height { get => _height; set => _height = value; }
        public double Weight { get => _weight; set => _weight = value; }

        //Constructor
        public Patient(string name, double height, double weight): base(name)
        {
      
            Height = height;
            Weight = weight;
        }
        //Functions
        public double GetBMI()
        {
            return Weight / (Height * Height);
        }
        public string GetBodyStatus()
        {
            double bmi = GetBMI();

            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }

        public override string GetInfo()
        {
       
            return $"Patient Name : {Name} \n" +
                    $"Patient Height : {Height} \n" +
                    $"Patient Weight : {Weight}\n " +
                    $"Patient BMI : {GetBMI()}\n" +
                    $"Patient Body Status  : {GetBodyStatus()} ";
        
        }

        public void PrintDetails()
        {
           Console.WriteLine($"Patient Name : {Name} \n" +
                               $"Patient Height : {Height} \n" +
                    $"Patient Weight : {Weight}\n " +
                    $"Patient BMI : {GetBMI()}\n" +
                    $"Patient Body Status  : {GetBodyStatus()} ");
        }
    }
}
