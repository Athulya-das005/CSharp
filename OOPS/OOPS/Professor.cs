using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Professor
    {
        // Private fields (hidden from outside the class)
        private string _name;
        private int _age;

        // Method to set the name
        public void SetName(string name)
        {
            _name = name;
        }

        // Method to get the name
        public string GetName()
        {
            return _name;
        }

        // Method to set the age with validation
        public void SetAge(int age)
        {
            if (age > 0) // Validation
                _age = age;
            else

                Console.WriteLine("Age must be greater than 0.");
        }

        // Method to get the age
        public int GetAge()
        {
            return _age;
        }

        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }
    }


}

