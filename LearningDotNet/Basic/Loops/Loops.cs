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
    }
}
