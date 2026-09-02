using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_4.DashBoardNewVirson
{
     class StudentClass
    {
        public  void PrintStudentPanner()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Task 2: Student Percentage");
            Console.WriteLine("===============================");
        }
        public  double CalculatePercentage(double Mark, double FullMark)
        {
            return (Mark / FullMark) * 100;
        }
        public  string GetGrade(double percentage)
        {
            // double  percentage = CalculatePercentage(Mark, FullMark);

            if (percentage >= 85)
                return "Excellent";
            else if (percentage >= 75)
                return "Very Good";
            else if (percentage >= 65)
                return "Good";
            else if (percentage >= 50)
                return "Pass";
            else
                return "Failed";
        }
        public  string[] GetStudentSummary(string studentName, double mark, double fullmark)
        {
            
            return new string[] { "Student Name: " + studentName,
                                  "Obtained Mark: " + mark,
                                  "Full Mark: " + fullmark,
                                  "Percentage: " +  CalculatePercentage(mark, fullmark) + "%",
                                  "Grade: " +       GetGrade( CalculatePercentage(mark, fullmark)) };


        }

    }
}
