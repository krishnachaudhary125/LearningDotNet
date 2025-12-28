using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDotNet.Basic.Loops
{
    internal class Loops
    {
        internal void QuestionEleven()
        {
            int num;
            Console.Write("Enter a number to print from 1 to n : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <=num; i++)
            {
                Console.WriteLine("\n" + i);
            }
        }

        internal void QuestionTwelve()
        {
            int num, result;
            Console.Write("Enter a number to print its multiplication table : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMultiplication table of " + num);

            for(int i =1; i<=10; i++)
            {
                result = num * i;
                Console.WriteLine(num+ " * "+i+" : "+result);
            }
        }

        internal void QuestionThirteen()
        {
            int num, result;
            Console.Write("Enter n natural number : ");
            num = Convert.ToInt32(Console.ReadLine());

            result = (num * (num + 1)) / 2;

            Console.WriteLine("\nSum of first "+num+" natural numbers : "+result);
        }

        internal void QuestionFourteen()
        {
            int num, temp=0, digit;
            Console.Write("Enter a number to reverse : ");
            num = Convert.ToInt32(Console.ReadLine());
            int original = num;

            while (num > 0)
            { 
                digit = num % 10;
                temp = temp * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine("\nReverse of "+original+ " : "+ temp);
        }
    }
}
