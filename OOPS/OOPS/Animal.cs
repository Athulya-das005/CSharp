using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Animal
    {
        public virtual void MakeSound()//virtual method (can be overriden in deives classes)
        {
            Console.WriteLine("all animals makes sound");

        }
    }

    //derived class
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("boww bowww");
        }
    }
}
    


    

