using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDotNet.Basic.Conditions
{
    internal class Conditions
    {
        internal void QuestionSix()
        {
            int num1, num2, num3;
            Console.Write("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            String res = (num1 > num2)
                ? ((num1 > num3) ? (num1 + " is greatest.") : (num3 + " is greatest."))
                : ((num2 > num3) ? (num2 + " is greatest.") : (num3 + " is greatest."));

            Console.WriteLine("\n" + res);
        }

        internal void QuestionSeven() 
        {
            int num;
            Console.Write("Enter number to check positive, negative or zero : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("\n" + num + " is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("\n" + num + " is negative.");
            }
            else
            {
                Console.WriteLine("\nThe number is zero.");
            }
        }

        internal void QuestionEight()
        {
            int year;
            Console.Write("Enter year to check leap year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if((year % 4 == 0 && year % 100 !=0)|| (year % 400 == 0))
            {
                Console.WriteLine("\n" + year + " is a leap year.");
            }
            else
            {
                Console.WriteLine("\n" + year + " is not a leap year.");
            }
        }

        internal void QuestionNine()
        {
            double marks;
            Console.Write("Enter the marks to check grade : ");
            marks = Convert.ToDouble(Console.ReadLine());

            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine("\n" + marks + " is A+.");
            }
            else if (marks >= 80 && marks < 90)
            {
                Console.WriteLine("\n" + marks + " is A.");
            }
            else if (marks >= 70 && marks < 80)
            {
                Console.WriteLine("\n" + marks + " is B+.");
            }
            else if (marks >= 60 && marks < 70)
            {
                Console.WriteLine("\n" + marks + " is B.");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("\n" + marks + " is C+.");
            }
            else if (marks >= 40 && marks < 50)
            {
                Console.WriteLine("\n" + marks + " is C.");
            }
            else
            {
                Console.WriteLine("\nNot Graded.");
            }

        }
    }
}
