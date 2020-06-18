using System;
using System.Collections.Generic;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Array Fixed Size Array
            int[] grades = new int[5];
            //5 spaces means you have addresses 0, 1, 2, 3, 4
            // if n is the size of array, then your array addresses are 0 to n-1

            //Assign Values to the Fixed Size Array
            //grades[0] = 15;
            //grades[1] = 20;
            //grades[2] = 35;
            //grades[3] = 12;
            //grades[4] = 10;

            //grades = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Enter students grades");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            //Print Values in Fixed Size Arrays
            Console.WriteLine("The grades you entered are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(grades[i]);
            }


            //Declare Variable Size Arrays
            int[] grades1;
            int grade = 0;
            int index = 0;

            //Assign values to the Variable Size Arrays
            grades1 = new int[] { 10, 20, 30, 40, 50, 1, 2, 3, 4, 5 };

            //Print Values in Variable Size Arrays
            Console.WriteLine("The grades you entered are");
            for (int i = 0; i < grades1.Length; i++)
            {
                Console.WriteLine(grades1[i]);
               
            }
            //Declare a List
            List<string> names = new List<string>();
            string name = "";
            //Add Values to the List
            names.Add("Drake");
            Console.WriteLine("Enter Names: ");
            while (!name.Equals("-1"))
            {
                name = Console.ReadLine();
                if (!name.Equals("-1"))
                {
                    names.Add(name);
                }
            }
            //printing list value using for loop 
            Console.WriteLine("The  Students names you entered are(for loop)");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);

            }
            //printing list value using foreach loop 
            Console.WriteLine("The  Students names you entered are(foreach loop)");

            foreach (string item in names)
            {
                Console.WriteLine(item);

            }



        }
    }
}
