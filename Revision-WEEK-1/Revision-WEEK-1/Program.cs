namespace Revision_WEEK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1-createing a class and its objects and accesing method ,properties etc 


            //creating objects of car class
            Car car1 =new Car("toyota","new",2025);
            Car car2 = new Car("maruti","old",2002);

            //accessing properties:
            Console.WriteLine($"car 1: name:{car1.name},model : {car1.model},year : {car1.year}");
            Console.WriteLine($"car 2: name:{car2.name},model : {car2.model},year : {car2.year}");

            //acccessing methods:
            car1.StartEngine();
            car2.DisplayCarInfo();
            car1.StopEngine();

            //----------------------//


            // inheritance as a mechanism for creating a new class that inherits properties and behavior from an existing one:


            Bike Mybike = new Bike();

            Mybike.Start();
            Mybike.Stop();
            Mybike.Accelerate();


                








































































            Console.ReadKey();

        }



    }
   
}
