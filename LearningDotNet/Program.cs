using LearningDotNet.Basic.IO;
using LearningDotNet.Basic.Conditions;
using LearningDotNet.Basic.Loops;

class Program
{
    public static void Main(string[] args)
    {
        int n;
        Questions que = new Questions();
        Conditions con = new Conditions();
        Loops loop = new Loops();

        do
        {
            Console.Write("----------------------------------------------\nEnter the question number or exit(0) : ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n== 0)
            {
                break;
            }

            switch (n)
            {
                case 1:
                    Console.WriteLine("\n" + n + ". Write a program to display Hello World!!.\n");
                    que.QuestionOne();
                    break;

                case 2:
                    Console.WriteLine("\n" + n + ". Take name and age as input and display them.\n");
                    que.QuestionTwo();
                    break;

                case 3:
                    Console.WriteLine("\n" + n + ". Convert Celsius to Fahrenheit.\n");
                    que.QuestionThree();
                    break;

                case 4:
                    Console.WriteLine("\n" + n + ". Find area of a circle.\n");
                    que.QuestionFour();
                    break;

                case 5:
                    Console.WriteLine("\n"+n+ ". Check whether a number is odd or even.\n");
                    que.QuestionFive();
                    break;

                case 6:
                    Console.WriteLine("\n" + n + ". Find the largest of three numbers.\n");
                    con.QuestionSix();
                    break;

                case 7:
                    Console.WriteLine("\n" + n + ". Check whether a number is positive, negative, or zero.\n");
                    con.QuestionSeven();
                    break;

                case 8:
                    Console.WriteLine("\n"+n+ ". Check whether a year is a leap year.\n");
                    con.QuestionEight();
                    break;

                case 9:
                    Console.WriteLine("\n" + n + ". Calculate grade based on marks.\n");
                    con.QuestionNine();
                    break;

                case 10:
                    Console.WriteLine("\n" + n + ". Simple calculator using switch-case.\n");
                    con.QuestionTen();
                    break;

                case 11:
                    Console.WriteLine("\n" + n + ". \n");
                    loop.QuestionEleven();
                    break;

                case 12:
                    Console.WriteLine("\n"+ n + ". Print multiplication table of a number.\n");
                    loop.QuestionTwelve();
                    break;
            }
        } while (true);
    }
}