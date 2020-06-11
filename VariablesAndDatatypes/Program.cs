using System;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //data types
            string name;
            int age;
            double salary;
            char gender;
            bool working;

            //prompt users for input
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your gender: (M / F) ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you employed (true or false):  ");
            working = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is:{0} ", age);
            Console.WriteLine($"Your salary is {salary} ");
            Console.WriteLine($"Your gender is {gender} ");
            Console.WriteLine($"You are employed:  {working}");








        }
    }
}
