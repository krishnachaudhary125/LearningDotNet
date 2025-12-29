using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDotNet.Intermediate.NumbersProgram
{
    internal class Numbers
    {
        internal void QuestionSixteen()
        {
            int num, rev = 0, digit, temp;
            Console.Write("Enter number to check palindrome : ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num > 0)
            {
                digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }

            if(temp == rev)
            {
                Console.WriteLine("\n" + temp + " is a palindrome number.");
            }
            else
            {
                Console.WriteLine("\n" + temp + " is not a palindrome number.");
            }
        }

        internal void QuestionSeventeen()
        {
            int num, digit, sum = 0, original, length;
            Console.Write("Enter number to check armstrong number : ");
            num = Convert.ToInt32(Console.ReadLine());
            original = num;
            length = num.ToString().Length;

            while (num > 0)
            {
                digit = num % 10;
                sum = (sum + (int) Math.Pow(digit, length));
                num = num / 10;
            }

            if (original == sum)
            {
                Console.WriteLine("\n" + original + " is an armstrong number.");
            }
            else
            {
                Console.WriteLine("\n" + original + " is not an armstrong number.");
            }
        }
    }
}
