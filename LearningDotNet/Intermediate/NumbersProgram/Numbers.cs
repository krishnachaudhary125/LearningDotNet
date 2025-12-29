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

        internal void QuestionEighteen()
        {
            Console.WriteLine("Prime numbers : \n");
            for(int i = 2; i<=100; i++)
            {
                bool isPrime = true;

                for(int j = 2; j<=Math.Sqrt(i); j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        internal void QuestionNineteen()
        {
            int num, result = 0; ;
            Console.Write("Entet the length of fibonacci series : \n");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<=num; i++)
            {
                result = result + i;
                Console.Write(result + " ");
            }
            Console.WriteLine();
        }

        internal void QuestionTwenty()
        {
            int num, count = 0;
            Console.Write("Enter number to count its digits : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("\n"+"Number of digits is : "+count);
        }
    }
}
