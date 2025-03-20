using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Fruit//class name
    {
        public string color;//a property or value in a class
        public string name;
        //fields:
        //classinte agath verunna variableine "Fields " enn parayunnu.(ex:color)
        //Syntax:object.field

        //constructors:
        //initial values set cheyyunadh korachudi easy aakan an idh use cheyyunadh .adh classin aghath verunna oru special fun aan constructors
        public Fruit(string FruitColor,string FruitName)
        {
            color = FruitColor;
            name = FruitName;
        }



        //object method:
        //classinte agath verunna methodsine ann object methods enn parayanadh
        //here displayName() is a method 
        public void DisplayName()
        {
            Console.WriteLine(name);
          
        }
        public void DisplayColor()
        {
            Console.WriteLine(color);
        }


       


        

            



    } 
}
