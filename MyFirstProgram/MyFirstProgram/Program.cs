using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //BASICS OF C# :-

            //1-VARIABLES AND DATATAYPE :


            //int a;
            //a = 10;
            //int b = 30;


            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(a + b);



            //int age = 20;//whole number
            //Console.WriteLine("my age is " + age);


            //double height = 300.5;//decimal numbers 
            //Console.WriteLine("my height is " + height);

            //bool alive = false;//true or false
            //Console.WriteLine("is she alive" + alive);

            //char symbol = '@';//single charecter
            //Console.WriteLine("my symbol is " + symbol);

            //string name = "athulya";
            //Console.WriteLine("my name is " + name);

            //string username = symbol + name;
            //Console.WriteLine("my username is " + username);


            /////////////////////////////////////////////////////




            ////TYPE CASTING:---



            ////implicit casting:

            //int num = 10;
            //double d = num;  // Implicit casting from int to double

            //float f = 5;     // Implicit casting from int to float

            //Console.WriteLine("implicit: " + d);  // Output: 10.0
            //Console.WriteLine("implicit: " + f);  // Output: 5


            ////explicit casting :-

            //double s = 10.5;
            //int nums = (int)s;  // Explicit casting from double to int

            //Console.WriteLine("explicit: " + nums);  // Output: 10 (decimal part is lost)

            ////convert class useing methods:-

            //string str = "123";
            //int number = Convert.ToInt32(str);

            //Console.WriteLine(number);


            ////parse method:-

            //string numberstring = "12345";

            //int numberr = int.Parse(numberstring);

            //Console.WriteLine("converted from string to number " + numberr);



            ////useing tryparse():-




            //string input = "9283";

            //if (int.TryParse(input, out int result))
            //{
            //    Console.WriteLine("The conversion is succcessful and the number is: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("the conversion was failed ,invalid number");
            //}


            ////valur type:-

            //int w = 110;
            //int z = w;  // A copy of 'w' is assigned to 'z'

            //w = 111;  // Changing 'w' does not affect 'z'

            //Console.WriteLine(w); // Output: 20
            //Console.WriteLine(z); // Output: 10 (Remains unchanged)

            ////reference type:-



            ////                              class Person
            ////        {
            ////            public string Name;
            ////        }

            ////        Person p1 = new Person();
            ////        p1.Name = "Alice";

            ////Person p2 = p1;  // p2 now refers to the same object as p1

            ////        p1.Name = "Bob";  // Changing p1 also changes p2

            ////Console.WriteLine(p1.Name); // Output: Bob
            ////Console.WriteLine(p2.Name); // Output: Bob (Same object)




            ////pointers:-

            ////unsafe
            ////{
            ////    int num = 10;  // Normal integer variable
            ////    int* ptr = &num;  // Pointer storing the memory address of 'num'

            ////    Console.WriteLine((int)ptr);  // 6422292-Prints memory address
            ////    Console.WriteLine(*ptr);      //10- Prints value at that address (10)
            ////}


            ////pointer arithmetic:-

            ////unsafe
            ////{
            ////    int arr[] = { 10, 20, 30 };
            ////    fixed (int* ptr = arr) // Fix array in memory
            ////    {
            ////        Console.WriteLine(*ptr);       // 10
            ////        Console.WriteLine(*(ptr + 1)); // 20
            ////        Console.WriteLine(*(ptr + 2)); // 30
            ////    }
            ////}
            ////



            ///////////////////////////////////////////////////



            ////TASK:-
            ////Perform arithmetic operations (addition, subtraction, multiplication, division)
            ////on the numbers and display the results.

            //int k = 10;
            //int j = 20;

            //Console.WriteLine("addition: " + (k + j));
            //Console.WriteLine("sub: " + (j - k));
            //Console.WriteLine("multiplication: " + (k * j));
            //Console.WriteLine("division: " + (j / k));
            //Console.WriteLine("modulus: " + (j % k));

            ////struct:

            ////       struct Person
            ////{
            ////    public string Name;
            ////    public int Age;

            ////    public void Display()
            ////    {
            ////        Console.WriteLine($"Name: {Name}, Age: {Age}");
            ////    }
            ////}






            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//





            //TASK :

            //Q: find the hypotenuese of a triamgle?
            //ans:


            //Console.WriteLine("enter side A: ");
            //double a = Convert.ToDouble(Console.ReadLine());//reads user input as a string 

            //Console.WriteLine("enter side  B: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt((a * a) + (b * b));//c=a2(square)+b2(square);

            //Console.WriteLine("the hypotenuse is :" + c);

            //control flows and loop in c:

            //------------------------------------------------------------------------//


            //CONTROL FLOWS AND LOOPS :

            //If statement:


            //if statement and else statement


            //int age = 20;

            //if (age >= 20)
            //{
            //    Console.WriteLine("adult");
            //}
            //else
            //{
            //    Console.WriteLine("not adult");
            //}

            //else if :


            //int number = 40;

            //if (number >= 50)
            //{
            //    Console.WriteLine("number is greater than or equal to 50");
            //}
            //else if (number < 10 )
            //{
            //    Console.WriteLine("number is less than 10");
            //}
            //else
            //{
            //    Console.WriteLine("number is less than  50");
            //}



            //switch:



            //switch (expression)
            //{
            //    case value1:
            //        // Code for value1
            //        break;
            //    case value2:
            //        // Code for value2
            //        break;
            //    default:
            //        // Default code if no match
            //        break;
            //}


            //loops:

            //for:

            //for(int i = 0; i <=5; i++)
            //{
            //    Console.WriteLine(i);
            //}




            //while loop:


            //int i = 1;

            //while (i<=5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //do-while:

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 5);




            //foreach;


            //string[] fruits = { "Apple", "Banana", "Cherry" };

            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}



            //----------------------------------------------------------------------------------------//

            //FUNCTIONS :-

            //fun useing no parameter and no return value:

            Greet();

            //fun with parameter  and without return value:

            PrintMessseage("Athulya");//passing argument 


            //fun with parameter and with return value

            int Sum = Add(10, 20);
            Console.WriteLine("sum:"+Sum);


            //pass by value and reference:

            //collections:-

            //ARRAY:

            int[] numbers = { 1, 2, 3, 4, 5 }; // Array declaration
            Console.WriteLine(numbers[0]);

            //List;

            //createing a list with initial elements

            //List<string> fruits = new List<string>() { "apple", "banana", "orange" };

            //adding elements to a list:

            List<string> fruits = new List<string>();

            fruits.Add("apple");
            fruits.Add("Banana");

            //add multiple elements:

            fruits.AddRange(new[] {"cherry","date" });
            Console.WriteLine(string.Join("," ,fruits));
            //removeing elements:


            List<string> newfruits = new List<string>() { "Apple", "Banana", "Cherry", "Date" };

            // Remove by value
            newfruits.Remove("Banana");
            // Remove by index
            newfruits.RemoveAt(0); // Removes "Apple"

            // Remove all elements matching a condition
            newfruits.RemoveAll(fruit => fruit.StartsWith("C")); // Removes "Cherry"

            // Clear all elements
            newfruits.Clear();


            //dict:

            Dictionary<string, int> ages = new Dictionary<string, int>();

            //adding a n element
            ages.Add("alice",25);

            //add or updateing elements
            ages["charlie"] = 35;
            ages["alice"] = 26;

            //accessing elements

            Dictionary<string, string> capitals = new Dictionary<string, string>()
{
    { "USA", "Washington, D.C." },
    { "France", "Paris" },
    { "Japan", "Tokyo" }
};

            // Access by key
            Console.WriteLine(capitals["USA"]); // Output: Washington, D.C.

            // Check if a key exists before accessing
            if (capitals.ContainsKey("France"))
            {
                Console.WriteLine(capitals["France"]); // Output: Paris
            }

            // Iterate through the dictionary
            foreach (KeyValuePair<string, string> kvp in capitals)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // Get all keys
            foreach(string country in capitals.Keys)
            {

                Console.WriteLine(country);
            }

            // Get all values
            foreach (string capital in capitals.Values)
            {
                Console.WriteLine(capital);
            }

            //HASH:

            string input = "helloo";
            int hashcode = input.GetHashCode();
            Console.WriteLine(hashcode);

            //boxing and unboxing 
            //string interpolation :-

            int age = 20;
            string messeage = $"iam athulya,iam {age} years old";
            Console.WriteLine(messeage);


            //composite formatting :-
            //printing using index
          
          

            //GENERICS:

            
            Box<int> intBox = new Box<int>();
            intBox.Add(123);
            Console.WriteLine(intBox.Get());






































































            //main method ends here
            Console.ReadKey();
        }


        static void Greet()
        {
            Console.WriteLine("hello ,welcome to c#");
        }

        static void PrintMessseage(string name)
        {
            Console.WriteLine("Hello "+name);
        }


        

       static int Add(int a,int b)
        {
            return a + b;
        }


       

        }

    }


