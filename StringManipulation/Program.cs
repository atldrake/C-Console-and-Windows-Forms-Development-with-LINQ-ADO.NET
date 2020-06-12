using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a String Variable
            string fullName = "My full name is Al-Husayn Abubakr";
            string firstName = "Al-husayn";
            string lastName = "Abubakar";

            // Print To Screen
            Console.WriteLine(fullName);

            //Concatenation
            Console.WriteLine("My full name is {0} {1} ", firstName, lastName);
            Console.WriteLine("My full name is " + firstName + " " + lastName);
            Console.WriteLine($"My full name is {firstName} {lastName}");
            //Count Length of String
            int length = firstName.Length;
            Console.WriteLine(length);

            int length1 = fullName.Length;
            Console.WriteLine(length1);
            //Replace Parts of Length
            string newName = firstName.Replace('A', 'F');
            string newName1 = lastName.Replace('a', 'o');
            string newName2 = lastName.Replace("Al-husayn", "ATL Drake");
            Console.WriteLine(newName);
            Console.WriteLine(newName1);
            Console.WriteLine(newName2);
            //Append to Existing String

            //Strings Splits

            //Compare Strings
            if (firstName == lastName)
            {
                Console.WriteLine("First Name and Last Name is the same");
            }
            else
            {
                Console.WriteLine("First and Last are different");
            }
            int result = string.Compare(firstName, lastName);
            if (result == 0)
            {
                Console.WriteLine("First Name and Last Name is the same");

            }
            else
            {
                Console.WriteLine("First and Last are different");

            }

            //Convert to Strings
             result = 123456789;
            string bigNumber = result.ToString();
            Console.WriteLine($"My bank Acnt number is {bigNumber}");

            //
        }
    }
}
