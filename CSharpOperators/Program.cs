using System;

namespace CSharpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Assignment operators
            int num;
            num = 5;
            Console.WriteLine(num);

            //Arithmetics Operators
            int x = 11;
            int y = 3;

            Console.WriteLine($"Addition: {x + y}");
            Console.WriteLine($"Subtraction: {x - y}");
            Console.WriteLine($"Multiplication: {x * y}");
            Console.WriteLine($"Division: {x / y}");
            Console.WriteLine($"Modulos: {x % y}");

            x = x + 4;
            Console.WriteLine($"New value of x is : {x}");

            Console.WriteLine($"Addition: {x + y}");
            Console.WriteLine($"Subtraction: {x - y}");
            Console.WriteLine($"Multiplication: {x * y}");
            Console.WriteLine($"Division: {x / y}");
            Console.WriteLine($"Modulos: {x % y}");

            // Compound Assignment Operators
            x += 5; //x = x + 5;
            Console.WriteLine(x);

            x -= 5; //x = x - 5;
            Console.WriteLine(x);

            x *= 5; //x = x * 5;
            Console.WriteLine(x);

            x /= 5; //x = x / 5;
            Console.WriteLine(x);

            x %= 5; //x = x % 5;
            Console.WriteLine(x);

        }
    }
}
