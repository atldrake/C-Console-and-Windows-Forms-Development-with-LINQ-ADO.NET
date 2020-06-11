using System;

namespace Methods
{
    class Program
    {
        // Void Function
        static void PrintName()
        {
            Console.WriteLine("FirmTech Solutions");
        }
        static void PrintName(string name )
        {
            Console.WriteLine(name.ToUpper());
        }
        static void PrintNameLowerCase(string name )
        {
            Console.WriteLine(name.ToLower());
        }


        // Value Returning Function
        static int LargestNumber(int num1, int num2, int num3)
        {
            int largest = num1;
            if ( num2 > largest)
            {
                largest = num2;
            }
            if (num3 > largest)
            {
                 largest = num3;
            }
            return largest;

        }
        static void Main(string[] args)
        {
            //Void Function Call
            PrintName();
            Console.WriteLine("Void function ends here");

            Console.WriteLine("Enter a name");
            string n = Console.ReadLine();
            PrintName(n);

            Console.WriteLine("Void function Upper case ends here");
            PrintNameLowerCase(n);
            Console.WriteLine("Void function Lower case ends here");



            //Value Returning Function Call
            Console.WriteLine("Enter First number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First number");
            int n3 = int.Parse(Console.ReadLine());
            ;
            int result = LargestNumber(n1, n2, n3);
            Console.WriteLine($"Largest Number is {result}");
        }
    }
}
