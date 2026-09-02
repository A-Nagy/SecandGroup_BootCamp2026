using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_4.DashBoardNewVirson
{
     class PatientClass
    {
        public void PrintPatientPanner()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Task 3: Paitent BMI Calcualtor");
            Console.WriteLine("===============================");
        }
        public double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }
        public string GetBodyStatus(double weight, double height)
        {
            double bmi = CalculateBMI(weight, height);

            return (bmi < 18.5) ? "Underweight" :
                   (bmi < 25) ? "Normal Weight" :
                   (bmi < 30) ? "Overweight" : "Obese";

        }
        public string[] GetPatientSummary(string PatientName, double Height, double Weight)
        {

            return new string[] {  $"Patient Name is : " + PatientName,
                                   $"Patient Height is : {Height} M " ,
                                   $"Patient Weight is : {Weight} K.g",
                                   $"Patient BMI Is : {CalculateBMI(Weight,Height)}",
                                   $"Patient Body Status is : {GetBodyStatus(Weight,Height)}"};


        }

    }
}
