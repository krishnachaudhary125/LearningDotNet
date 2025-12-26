using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LearningDotNet.Basic.IO
{
    internal class Questions
    {
        const double pi = 3.14;
        internal void QuestionOne()
        {
            Console.WriteLine("Hello World!!");
        }

        internal void QuestionTwo()
        {
            string name;
            int age;

            Console.Write("Enter name : ");
            name = Console.ReadLine();
            Console.Write("Enter age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nName : " + name + "\n" + "Age : " + age);
        }

        internal void QuestionThree()
        {
            double feranhite, celsius;

            Console.Write("Enter celsius to convert : ");
            celsius = Convert.ToDouble(Console.ReadLine());

            feranhite = celsius * ((double)9/5) + 32;
            Console.WriteLine("\nFeranhite : " + feranhite);
        }

        internal void QuestionFour()
        {
            double radius, area;

            Console.Write("Enter radius of circle : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = pi * radius * radius;
            Console.WriteLine("\nArae : " + area);
        }

        internal void QuestionFive()
        {
            int num, temp;

            Console.Write("Enter any number to check odd or even : ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num % 2;

            if(temp == 0)
            {
                Console.WriteLine("\n"+num+" is even number.");
            }
            else
            {
                Console.WriteLine("\n"+num + " is odd number.");
            }
        }
    }
}
