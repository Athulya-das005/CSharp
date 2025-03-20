using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public  abstract class Birds
    {
        public abstract void MakeSound();
        public void Fly()
        {
            Console.WriteLine("Birds can fly");
        }
    }
    public class Duck : Birds
    {
        public override void MakeSound()
        {
            Console.WriteLine("quak quakk");
        }
    }
}
