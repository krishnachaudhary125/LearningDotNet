using LearningDotNet.Basic.IO;

class Program
{
    public static void Main(string[] args)
    {
        int n;
        Questions que = new Questions();

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
            }
        } while (true);
    }
}