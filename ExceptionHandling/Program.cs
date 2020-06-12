using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try => a try block identifies a block of codes for which a particular Exception is activated
             * Catch => A program catches an exeption with an exception handler
             * finally = > the finally block is used to execute whether an exception is thrown or not
             * throw => A program throws an exception when a problem shows up

            */

            Console.WriteLine("Enter a first number ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number ");
            int n2 = int.Parse(Console.ReadLine());

            try
            {
                int result = n1 / n2;
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid operation entered: {e.Message}");

            }
            finally
            {
                Console.WriteLine("End of program");

            }
        }

    }
}
