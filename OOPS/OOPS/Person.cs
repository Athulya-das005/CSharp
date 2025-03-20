using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Person
    {
        public string name;
        public string age;

        public Person(string PersonName,string PersonAge)
        {
            name = PersonName;
            age = PersonAge;
        }

        public void DisplayName()
        {
            Console.WriteLine("fullname: "+name);
        }
        public void DisplayAge()
        {
            Console.WriteLine("age: "+age);
        }
    }
}
