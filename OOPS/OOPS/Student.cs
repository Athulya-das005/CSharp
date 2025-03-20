using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Student
    {

        // Private fields (hidden from outside the class)
        private string _name;
        private int _age;

        // Public properties to access and modify private fields
        public string Name
        {
            get { return _name; } // Getter
            set { _name = value; } // Setter
        }

        public int Age
        {
            get { return _age; } // Getter
            set
            {
                if (value > 0) // Validation
                    _age = value;
                else
                    Console.WriteLine("Age must be greater than 0.");
            }

        }
        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }
    }


}

