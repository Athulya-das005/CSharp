using Microsoft.Win32.SafeHandles;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //createing objects for the class fruit:
            Fruit Apple = new Fruit("red","apple"); 
            //Apple.color = "red";
            //Apple.name = "Apple";//we can simplify these two lines useing constructors
                                    
            Apple.DisplayName();//accessing useing method 
            Apple.DisplayColor();


            Person Athulya = new Person("athulya das", "20");

            Athulya.DisplayAge();
            Athulya.DisplayName();

            // 1-------------INHERITANCE:--------------//

           //ex1:-mobile is the parent class and android is the child class
           Android android = new Android();
            android.MakeCalls();

            //ex2:-
            Car MyCar = new Car();

            MyCar.Start();//access methods from the base class
            MyCar.Stop();

            //accessing methods from the child or derived class
            MyCar.Accelerate();


            //---------------POLYMORPHISM--------------//

            Animal animal = new Animal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            //method overloading and overrideing:

            //method overloading:-
            //multiple methods with the same name nd diff arguments:

            MathOperations math = new MathOperations();

             Console.WriteLine(math.Add(2,3));

            Console.WriteLine(math.Add(2,3,4));

            Console.WriteLine(math.Add(2.5, 3.5));


            //overrideing :
            // To change or extend the behavior of a method in the derived class.

            //same example of animal and dog 


            //---------------ABSTRACTION--------------//


            Duck bird = new Duck();
            bird.MakeSound();
            bird.Fly();


            //interface:

            IChatSystem W = new Whatsapp();
            W.SendMessage();


            //-------------------ENCAPSULATION-------------//



            //useing properties:

            // Create an object of the Person class
            Student student = new Student();

            // Set values using properties
            student.Name = "Alice";
            student.Age = 25;

            // Display details using a method
            student.DisplayDetails(); // Output: Name: Alice, Age: 25

            // Try to set invalid age
            student.Age = -5; // Output: Age must be greater than 0.
            student.DisplayDetails(); // Output: Name: Alice, Age: 25 (age remains unchanged)

            //useing methods:




            // Create an object of the Person class
            Professor professor = new Professor();

            // Set values using methods
            professor.SetName("Bob");
            professor.SetAge(30);

            // Display details using a method
            professor.DisplayDetails(); // Output: Name: Bob, Age: 30

            // Try to set invalid age
            professor.SetAge(-5); // Output: Age must be greater than 0.
            professor.DisplayDetails(); // Output: Name: Bob, Age: 30 (age remains unchanged

















































            Console.ReadKey();
        }



        
    }

    
}
 