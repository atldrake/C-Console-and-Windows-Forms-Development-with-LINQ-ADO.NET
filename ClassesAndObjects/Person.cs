using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private double _salary;

        public double getSalary()
        {
            return _salary;
        }
        public void setSalary( double salary)
        {
            _salary = salary;
        }
        public string getFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

    }
}
