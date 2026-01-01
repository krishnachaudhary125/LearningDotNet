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

        internal void QuestionTwentyTwo()
        {
            int[] num = new int[10] {123, 12, 147, 15, 16, 156, 1234, 127, 10, 1};
            int min = num[0];
            int max = num[0];
            for(int i = 0; i<num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                else if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.Write("Array : ");
            for(int i=0; i<num.Length; i++)
            {
                Console.Write(num[i]+ " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("\nMaximum number in array is "+max+"\nMinimum number in array is "+min);
        }

        internal void QuestionTwentyThree()
        {
            int[] num = new int[10] { 123, 12, 147, 15, 16, 156, 1234, 127, 10, 1 };
            int temp;
            int[] original = num;

            for(int i = 0; i < num.Length; i++)
            {
                for(int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.Write("Sorted Array : ");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
