using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_3.Function_11
{
     class Functions_11_2
    {
      public  static void EmployeeSalayInfo()
        {
           // declare variable
            string employeeName;
            double monthlySalary;
            double annualSalary;

            //2.Prompt the user to enter their name and monthly salary
            //inputs 
            Console.WriteLine("Enter your name:");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter your monthly salary:");
            monthlySalary = Convert.ToDouble(Console.ReadLine());

            //3.Calculate the annual salary
            annualSalary = monthlySalary * 12;

            //4.Display the employee's name, monthly salary, and annual salary

            Console.WriteLine("===============================");
            Console.WriteLine("Task 1: Employee Salary Info");
            Console.WriteLine("===============================");
            Console.WriteLine("Employee Name: "  + employeeName);
            Console.WriteLine("Monthly Salary: " + monthlySalary);
            Console.WriteLine("Annual Salary: "  + annualSalary);

            if (monthlySalary >= 15000)
            {
                Console.WriteLine("High Salary");
            }
            else if (monthlySalary >= 10000)
            {
                Console.WriteLine("normal Salary");
            }
            else if (monthlySalary >= 5000)
            {
                Console.WriteLine("Low Salary");
            }
            else
            {
                Console.WriteLine("very Low Salary");

            }

        }
      public  static void StudentGradeChecker()
        {


            //1.declare variables for student name, obtained mark, full mark, and percentage
            string studentName;
            double Mark;
            double FullMark;
            double percentage;
            //2.Prompt the user to enter their name, obtained mark, and full mark
            //inputs
            Console.WriteLine("Enter your name:");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter your  mark:");
            Mark = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your full mark:");
            FullMark = Convert.ToDouble(Console.ReadLine());
            //3.Calculate the percentage
            percentage = (Mark / FullMark) * 100;
            //4.Display the student's name, obtained mark, full mark, and percentage
            Console.WriteLine("===============================");
            Console.WriteLine("Task 2: Student Percentage");
            Console.WriteLine("===============================");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Obtained Mark: " + Mark);
            Console.WriteLine("Full Mark: " + FullMark);
            Console.WriteLine("Percentage: " + percentage + "%");
            if (percentage >= 85)
            { Console.WriteLine("Grade: Excellent"); }
            else if (percentage >= 75)
            { Console.WriteLine("Grade: Very Good"); }
            else if (percentage >= 65)
            { Console.WriteLine("Grade: Good"); }
            else if (percentage >= 50)
            { Console.WriteLine("Grade: Pass"); }
            else
            { Console.WriteLine("Grade: Failed"); }

        }
      public  static void BMI_Calcuator()
        {

            //declare variable 
            string PatientName;
            double height;
            double weight;
            double bmi;

            //input from user 
            Console.WriteLine("pls enter your Name ");
            PatientName = Console.ReadLine();
            Console.WriteLine("pls Enter Your height");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pls Enter Your Weight");
            weight = Convert.ToDouble(Console.ReadLine());

            //calculate Bmi 
            bmi = weight / (height * height);

            //Display Result 
            Console.WriteLine("Patient Name is : " + PatientName);
            Console.WriteLine($"Patient Height is : {height} M ");
            Console.WriteLine($"Patient Weight is : {weight} K.g");
            Console.WriteLine("Bmi : " + bmi);
            if (bmi > 18.5)
            { Console.WriteLine("Underweight"); }
            else if (bmi > 25)
            { Console.WriteLine("Normal Weight"); }
            else if (bmi > 30)
            { Console.WriteLine("Overweight"); }
            else
            {
                Console.WriteLine("Obese");
            }
        }

    }
}
