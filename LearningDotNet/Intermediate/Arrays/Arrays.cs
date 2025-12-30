using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDotNet.Intermediate.Arrays
{
    internal class Arrays
    {
        internal void QuestionTwentyOne()
        {
            int n;
            Console.Write("Enter the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];

            Console.Write("Enter numbers : ");
            for(int i=0; i<n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nNumbers in array are : ");
            foreach(int a in num)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();
        }
    }
}
