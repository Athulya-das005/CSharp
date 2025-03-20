using System.ComponentModel;
using System.Xml.Linq;

namespace LINQ
{
    internal class Program
    {

        //we have a list of people, and we want to query those who are older than 30.


        //query syntax:
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }


        static void Main(string[] args)
        {


            //data source: a list of peoples
            List<Person> people = new List<Person>
            {
                new Person { Name = "john", Age = 25 },
                new Person { Name = "jane", Age = 34 },
                new Person { Name = "sam", Age = 41 },
                new Person { Name = "anna", Age = 29 }

            };


            //LINQ query to get people older than 30

            var olderThan30 = from person in people//specifies the data soure
                              where person.Age > 30
                              select person;

            //output the result:

            foreach (var person in olderThan30)
            {
                Console.WriteLine($"{person.Name},Age: {person.Age}");
            }



            //ex-2


            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// Query Syntax: Get even numbers
            //var evenNumbers = from num in numbers
            //                  where num % 2 == 0
            //                  select num;

            //Console.WriteLine("Even Numbers:");
            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}





            //doing the same question question useing method in linq 

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var newnum = numbers.Where(x => x % 2 == 0).ToList();
            //foreach (var number in newnum)
            //{
            //    Console.WriteLine(number);
            //}






            //Write a LINQ query to transform each number in a list by multiplying it by 2.


            //Select:


            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var doublenum = numbers.Select(x => x * 2).ToList();

            //foreach (var number in doublenum)
            //{
            //    Console.WriteLine(number);
            //}



            //Write a LINQ query to filter out all odd numbers from a list and return only the even ones.


            //Where:

            //List<int> nums = new List<int> { 1, 7, 3, 2, 4, 9, 8, 42, 66, 97, 43 };

            //var Oddnums = nums.Select(x => x % 2 != 0).ToList();
            //var evennums = nums.Select(x => x % 2 == 0).ToList();


            //foreach(var odd in Oddnums)
            //{
            //    Console.WriteLine(odd);
            //}

            //foreach(var num in evennums)
            //{
            //    Console.WriteLine(num);
            //}



            //filtereing : where;

            //evnnums:


            //List<int> Numbers = new List<int> { 6, 3, 2, 8, 5, 3, 1, 9, 4 };
            //var evnnum = Numbers.Where(x => x % 2 == 0).ToList();
            //foreach (var number in evnnum)
            //{
            //    Console.WriteLine(number);
            //}


            //select:

            //var numberss = new[] { 1, 2, 3, 4 };
            //var suquaares = numberss.Select(n => n * n).ToList();

            //foreach (var number in suquaares)
            //{
            //    Console.WriteLine(number);
            //}


            //OrderBy:


            //var numbers = new[] { 4, 1, 3, 2 };
            //var sortedNumbers = numbers.OrderBy(n => n);  // Returns [1, 2, 3, 4]

            //foreach (var number in sortedNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //orderbydesending:

            //var array = new[] { 1, 2, 3, 4, 5 };
            //var desarr = array.OrderByDescending(n => n).ToList();

            //foreach (var number in desarr)
            //{
            //    Console.WriteLine(number);
            //}



            //ThenBY:
            //The ThenBy method is used for secondary sorting when there are multiple sorting conditions.

//            var students = new[]
//{
//    new { Name = "Alice", Age = 25 },
//    new { Name = "Bob", Age = 20 },
//    new { Name = "Charlie", Age = 25 }
//};
//            var sortedStudents = students.OrderBy(s => s.Age).ThenBy(s => s.Name);


//            foreach(var student in sortedStudents)
//            {
//                Console.WriteLine(student.Name);
//            }




            //FirstOrDefault:

            var numbers = new[] { 1, 2, 3, 4 };
            var firstEven = numbers.FirstOrDefault(n => n % 2 == 0);  // Returns 2

            Console.WriteLine(firstEven);



            //aggregate

            var numbersofarr = new[] { 1, 2, 3, 4, 5 };
            var sum = numbersofarr.Aggregate((total, n) => total + n);
            Console.WriteLine(sum);

            //any();

            var numb = new[] { 1, 2, 3, 4 };
            var hasEvenNumbers = numb.Any(n => n % 2 == 0);  // Returns true

            Console.WriteLine(hasEvenNumbers);


            //All:

            var num = new[] { 1, 2, 3, 4 };
            var alleven = num.All(n => n % 2 == 0);  // Returns true
            Console.WriteLine(alleven);


            //distinct:
            var arr1 = new[] { 1, 2, 2, 3, 4, 4 };
            var uniqueNumbers = arr1.Distinct();  // Returns [1, 2, 3, 4]

               foreach(var number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }



            //groupby:

            var students = new[] {

                           new {name= "athulya",age="20"},
                           new {name= "sidha",age="21"},
                           new {name= "ridila",age="19"}

                           };

            var groupedAge = students.GroupBy(s => s.age);

            foreach ( var group in groupedAge)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach(var student in group)
                {
                    Console.WriteLine($"Name: {student.name},Age:{student.age}");
                }
            }


            //FINDING ODD AND EVEN:

            List<int> Numbers = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var data = numbers.GroupBy(x => x % 2 == 0 ? "even" : "odd");

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var dt in item)
                {
                    Console.WriteLine(dt);
                }
            }


           

        }
    }
}
