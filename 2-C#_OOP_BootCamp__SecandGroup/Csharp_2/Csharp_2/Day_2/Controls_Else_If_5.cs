using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_2
{
     class Controls_Else_If_5
    {
        // static void Main(string[] args)
        //{
        //    Console.WriteLine("Pls Enter Number ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (num >= 100)
        //    {
        //        Console.WriteLine("this Number have more than 2  digits ");
        //    }
        //    else if (num >= 10)
        //    {
        //        Console.WriteLine("this Number have 2  digits ");
        //    }
        //    else if (num >= 0)
        //    {
        //        Console.WriteLine("this Number have 1 digits ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("this is negative number ");
        //    }

        //    //## ✅ Task 1: Employee Salary Info
        //    // **Objective:**
        //    //--Ask the employee to enter their name and monthly salary.
        //    //--Display their name, monthly salary, and calculated annual salary.
        //    //-Classify salary as:
        //    //-15,000 or more → "High Salary"
        //    // - 10,000 or more → "Normal Salary"
        //    // - 5,000 or more → "Low Salary"
        //    // - Less than 5,000 → "Very Low Salary"

        //    //declare variable
        //    string employeeName;
        //    double monthlySalary;
        //    double annualSalary;

        //    //2.Prompt the user to enter their name and monthly salary
        //    //inputs 
        //    Console.WriteLine("Enter your name:");
        //    employeeName = Console.ReadLine();
        //    Console.WriteLine("Enter your monthly salary:");
        //    monthlySalary = Convert.ToDouble(Console.ReadLine());

        //    //3.Calculate the annual salary
        //    annualSalary = monthlySalary * 12;

        //    //4.Display the employee's name, monthly salary, and annual salary

        //    Console.WriteLine("===============================");
        //    Console.WriteLine("Task 1: Employee Salary Info");
        //    Console.WriteLine("===============================");
        //    Console.WriteLine("Employee Name: " + employeeName);
        //    Console.WriteLine("Monthly Salary: " + monthlySalary);
        //    Console.WriteLine("Annual Salary: " + annualSalary);

        //    if (monthlySalary >= 15000)
        //    {
        //        Console.WriteLine("High Salary");
        //    }
        //    else if (monthlySalary >= 10000)
        //    {
        //        Console.WriteLine("normal Salary");
        //    }
        //    else if (monthlySalary >= 5000)
        //    {
        //        Console.WriteLine("Low Salary");
        //    }
        //    else
        //    {
        //        Console.WriteLine("very Low Salary");

        //    }


        //    //          ## ✅ Task 2: Student Percentage Calculator
        //    //            **Objective:**
        //    //            -Ask the student to enter their name, obtained mark, and full mark.
        //    //            -Calculate the percentage.
        //    //            -Display the name, marks, and percentage.
        //    //     - Classify grade based on percentage:
        //    //        -85 % or more → "Excellent"
        //    //      - 75 % or more → "Very Good"
        //    //      - 65 % or more → "Good"
        //    //     - 50 % or more → "Pass"
        //    //     - Below 50 % → "Failed"

        //    //1.declare variables for student name, obtained mark, full mark, and percentage
        //    string studentName;
        //    double Mark;
        //    double FullMark;
        //    double percentage;
        //    //2.Prompt the user to enter their name, obtained mark, and full mark
        //    //inputs
        //    Console.WriteLine("Enter your name:");
        //    studentName = Console.ReadLine();
        //    Console.WriteLine("Enter your  mark:");
        //    Mark = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Enter your full mark:");
        //    FullMark = Convert.ToDouble(Console.ReadLine());
        //    //3.Calculate the percentage
        //    percentage = (Mark / FullMark) * 100;
        //    //4.Display the student's name, obtained mark, full mark, and percentage
        //    Console.WriteLine("===============================");
        //    Console.WriteLine("Task 2: Student Percentage");
        //    Console.WriteLine("===============================");
        //    Console.WriteLine("Student Name: " + studentName);
        //    Console.WriteLine("Obtained Mark: " + Mark);
        //    Console.WriteLine("Full Mark: " + FullMark);
        //    Console.WriteLine("Percentage: " + percentage + "%");
        //    if (percentage >= 85)
        //    { Console.WriteLine("Grade: Excellent"); }
        //    else if (percentage >= 75)
        //    { Console.WriteLine("Grade: Very Good"); }
        //    else if (percentage >= 65)
        //    { Console.WriteLine("Grade: Good"); }
        //    else if (percentage >= 50)
        //    { Console.WriteLine("Grade: Pass"); }
        //    else
        //    { Console.WriteLine("Grade: Failed"); }


        //    //# ✅ Task 3: Patient BMI Calculator
        //    //            *Objective:**
        //    //            height(in meters), and weight(in kg).
        //    //            Calculate BMI using the formula:
        //    //            BMI = weight / (height * height)
        //    //            Display name, height, weight, and BMI.
        //    //  -Classify BMI as:
        //    /// -Less than 18.5        → "Underweight"
        //    //  - 18.5 to less than 25 → "Normal Weight"
        //   ///  - 25 to less than 30   → "Overweight"
        //   ///  - 30 or more           → "Obese"

        //        //declare variable 
        //        string PatientName;
        //        double height;
        //        double weight;
        //        double bmi;

        //        //input from user 
        //        Console.WriteLine("pls enter your Name ");
        //        PatientName = Console.ReadLine();
        //        Console.WriteLine("pls Enter Your height");
        //        height = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("pls Enter Your Weight");
        //        weight = Convert.ToDouble(Console.ReadLine());

        //        //calculate Bmi 
        //        bmi = weight / (height * height);

        //        //Display Result 
        //        Console.WriteLine("Patient Name is : " + PatientName);
        //        Console.WriteLine($"Patient Height is : {height} M ");
        //        Console.WriteLine($"Patient Weight is : {weight} K.g");
        //        Console.WriteLine("Bmi : " + bmi);
        //    if (Bmi > 18.5 )
        //    { Console.WriteLine("Underweight"); }
        //    else if (Bmi >25)
        //    { Console.WriteLine("Normal Weight"); }
        //    else if (Bmi > 30)
        //    { Console.WriteLine("Overweight"); }
        //     else
        //    {
        //    Console.WriteLine("Obese");
        //    }
        //        }
        //    }

    }
}
