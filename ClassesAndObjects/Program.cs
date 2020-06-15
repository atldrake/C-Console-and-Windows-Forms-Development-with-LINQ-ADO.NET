using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base variable and datatype declaration
            int num;

            //Create object of Class Type Box
            Box box = new Box();
            Box box2 = new Box();

            //Create object of Class Type Person
             Person person = new Person();

            Console.WriteLine("Enter Box 1 first number:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Box 1 second number:");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Box 1 third number:");
            double n3 = double.Parse(Console.ReadLine());

            //Setting values in objects properties
            box.Length = n1;
            box.Breadth = n2;
            box.Height = n3;
            double volume = box.getVolume();
            double area = box.getArea();

            Console.WriteLine("Enter Box 2 first number:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Box 2 second number:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Box 2 third number:");
            n3 = double.Parse(Console.ReadLine());

            //Setting values in objects properties
            box2.Length = n1;
            box2.Breadth = n2;
            box2.Height = n3;

            // getting values from objects properties
            Console.WriteLine($"Box 1 Dimensions are {box.Length}, {box.Breadth} and {box.Height}");
            Console.WriteLine($"Box 1 volume is {volume}");
            Console.WriteLine($"Box 1 Area is {area}"); 
            
            Console.WriteLine($"Box 2 Dimensions are {box2.Length}, {box2.Breadth} and {box2.Height}");
            Console.WriteLine($"Box 2 volume is {box2.getVolume()}");
            Console.WriteLine($"Box 2 Area is {box2.getArea()}");


            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();

            //Setting values in objects properties of Person Class
            person.FirstName = firstName;
            person.LastName = lastName;
            string fullName = person.getFullName();


            // getting values from objects properties
            Console.WriteLine($"Your Full Name is {fullName}");
            

        }
    }
    
}
