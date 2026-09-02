using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_3
{
    class Loops_9
     {
//         static void Main(string[] args)
//        {
//            //            //Console.WriteLine("1");
//            //            //Console.WriteLine("2");
//            //            //Console.WriteLine("3");
//            //            //Console.WriteLine("4");
//            //            //Console.WriteLine("5");
//            //            //Console.WriteLine("6");
//            //            //Console.WriteLine("7");
//            //            //Console.WriteLine("8");
//            //            //Console.WriteLine("9");
//            //            //Console.WriteLine("10");

//            //            // 1.for 
//            //            //conuter   //codition  // step
//            //            //for (int i = 1;   i<= 10  ; i++    )
//            //            //{
//            //            //    Console.WriteLine(i);
//            //            //}
//            //            /*
//            //             * ### `for` loop – Counting from 1 to 50  
//            //             Iterates using a counter,
//            //             useful when the number of repetitions is known.
//            //             */
//            //            //for (int i = 1; i <= 50; i++)
//            //            //{
//            //            //    Console.WriteLine(i);
//            //            //}
//            //            /////////////////////////
//            //            // 2.while

//            //            //int Counter = 1;
//            //            //while (Counter <= 10)
//            //            //{
//            //            //    Console.WriteLine(Counter);
//            //            //    Counter++;
//            //            //}

//            //            ///////////////////////
//            //            //bool state = true;
//            //            //while (state) 
//            //            //{
//            //            //    Console.WriteLine("Do You Want Stop y/n ");
//            //            //    string an= Console.ReadLine();
//            //            //    if (an == "y")
//            //            //    {
//            //            //        state = false;
//            //            //    }

//            //            //}
//            //            /*
//            //             * ### `while` loop – Login Simulation  
//            //                Repeats while a condition remains true. In this case,
//            //                until the username is "admin".
//            //             */
//            //            //string username = "";

//            //            //while (username != "admin") 
//            //            //{
//            //            //    Console.WriteLine("pls Enter UserName ");
//            //            //    username = Console.ReadLine().ToLower();
//            //            //}
//            //            //Console.WriteLine("Welcome , Admin");
//            //            ////////////////////////////////////////////

//            //            //3.Do... while

//            //            int Counter = 1;
//            //            do
//            //            {
//            //                Console.WriteLine(Counter);
//            //                Counter++;
//            //            } while (Counter >= 10);

//            //            /*
//            //             * ### `do-while` loop – Age Validation  
//            //            Always runs once, then checks if the entered age is within
//            //            the accepted range (18–60).
//            //             */
//            //            int age;
//            //            do
//            //            {
//            //                Console.WriteLine("Enter a Vaild Age (betwwen 18 and 60)");
//            //                age = Convert.ToInt32(Console.ReadLine());
//            //            }
//            //            while (age < 18 || age < 60);
//            //            Console.WriteLine("Accepted Age : "+age);
//            //            ////////////////////////////////////////

//            //            //4.foreach

//            //            string[] colors = { "red", "Green", "blue" };

//            //            for (int i = 0 ; i < colors.Length ; i++) 
//            //            {
//            //                Console.WriteLine(colors[i]);
//            //            }


//            //            foreach(string color in colors) 
//            //            {
//            //                Console.WriteLine(color);
//            //            }
//            //            /*
//            //             * ### `foreach` loop – Listing Cities  
//            //                   Used to iterate through arrays or collections 
//            //                   without needing an index.
//            //             */

//            //            string[] citites = { "Riyadh", "Cairo", "Dammam", "Jeddah" }
//            //            foreach (string city in citites)
//            //            {
//            //                Console.WriteLine(city);
//            //            }


//            //            /*
//            //             * 
//            //## ✅ Task 1: Print Numbers from 1 to 10 using a `for` loop  
//            //Print numbers from 1 to 10 on the console using a `for` loop.

//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine("Number : " + i);
//            }

//            //## ✅ Task 2: Sum of Even Numbers using `while` loop  
//            //  Ask the user to enter a number `n`,
//            //  then calculate the sum of all even numbers from 1 to `n`.

//            Console.WriteLine("pls Enter Number ");
//    int n = int.Parse(Console.ReadLine());
//    int s = 1;
//    double sum = 0;
//    while(n>=s)
//   {
//        if(s%2==0)
//        {
//         sum+= s;
//        }

//       s++;
//   }
//Console.WriteLine("The Sumation is : " + sum);

////## ✅ Task 3: Password Retry using `do-while` loop  
////Let the user enter a password and keep prompting
////            until they enter "admin123".
//string PassWord = "";
//do { 
//Console.WriteLine("Pls Enter password");
//PassWord= Console.ReadLine();
//} while (PassWord != "admin123") ;
//Console.WriteLine("Access Granted");

////## ✅ Task 4: List Items using `foreach` loop  
////Create an array of student names, and print each name using a 
////            `foreach` loop.

////             */
//string[] names = { "ahmad", "Soltan", "Omar", "samar", "sara" };
//foreach (string name in names) 
//{
//    Console.WriteLine("student name is : "+name);
//}
//         }

     }

}
