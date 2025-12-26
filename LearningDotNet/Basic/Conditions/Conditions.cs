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
    }
}
