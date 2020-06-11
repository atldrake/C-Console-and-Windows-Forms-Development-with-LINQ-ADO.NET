using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF Statement  (<, >, ==, <=, >=, !=)
            int num1 = 0;
            int num2 = 0;
            int num3;
            string result;
            Console.Write("How many apples do you have? ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many oranges do you have? ");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2)
            {
                Console.WriteLine("You have more Apples");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("You have more Oranges");

            }
            else if (num1 == num2)
            {
                Console.WriteLine("You have same number of  Apples and Oranges");

            }


            //Switch Statement
            Console.Write("How many eyes do you have? ");
            num3 = Convert.ToInt32(Console.ReadLine());
            switch (num3)
            {
                case 1:
                    Console.WriteLine("You have one eye");
                    break;
                case 2:
                    Console.WriteLine("You have two eyes");
                    Console.WriteLine("You have two eyes");
                    Console.WriteLine("You have two eyes");
                    Console.WriteLine("You have two eyes");
                    break;               
                default:
                    Console.WriteLine("Your input is Invalid");
                    break;

            }

            //Ternary Statement
            result = (num2 > num1) ? "You have more Oranges" : "You have more Apples";
            Console.WriteLine(result);
        }
    }
}
