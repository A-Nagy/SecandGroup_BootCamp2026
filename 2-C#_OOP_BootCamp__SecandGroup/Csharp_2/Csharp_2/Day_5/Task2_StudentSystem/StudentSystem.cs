using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Task2_StudentSystem
{
      class StudentSystem
    {
//        static void Main(string[] args)
//        {
//            /*
//              Student System
//- Create an **abstract class** `StudentBase` with:
//  - Properties: `Name`, `Mark`, `FullMark`
//  - Abstract Method: `GetPercentage()`
//- Create an **interface** `IGrading` with:
//  - Method: `GetGrade(double percentage)`
//- Implement a class `Student` that inherits from `StudentBase` and implements `IGrading`.

//             */
//        }

    }

    public abstract class StudentBase
    {
        protected StudentBase(string name, double mark, double fullMark)
        {
            Name = name;
            Mark = mark;
            FullMark = fullMark;
        }

        public string Name     { get; set; }
        public double Mark     { get; set; }
        public double FullMark { get; set; }
        public abstract double GetPercentage();

    }
    public interface IGrade
    {
        string GetGrade(double percentage);
    }
    public class Student : StudentBase, IGrade
    {
        public Student(string name, double mark, double fullMark) : base(name, mark, fullMark)
        {
        }

        public string GetGrade(double percentage)
        {
            if (percentage >= 85) return "Excellent";
            else if (percentage >= 75) return "Very Good";
            else if (percentage >= 65) return "Good";
            else if (percentage >= 50) return "Pass";
            else return "Failed";
        }

        public override double GetPercentage()
        {
            return (Mark / FullMark) * 100;
        }
    }

}
