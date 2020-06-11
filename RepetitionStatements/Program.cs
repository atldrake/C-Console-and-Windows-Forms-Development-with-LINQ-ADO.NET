using System;

namespace RepetitionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loops (counter controlled statement - samples print 5 times)
            Console.WriteLine("Enter a number between 5 and 10");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("I Love you");
                Console.WriteLine($"counter - {i}");
               
            }
            Console.WriteLine("for loop finished!!");
            Console.WriteLine();


            //Whle loops (Condition Controlled Statements - Pre Check)

            int count = 10;
            while (count < 5)
            {
                Console.Write("Input a number (0-4): ");
                count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered {count}");
                count += 1;

            }
            Console.WriteLine("while loop finished!!");
            Console.WriteLine();

            //do while loops (Condition Controlled Statements - Post Check)

            do
            {
                Console.Write("Input a number (0-4): ");
                count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered {count}");
                count += 1;
            } while (count < 5);

        }
    }
}
