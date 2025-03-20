namespace Practice
{
    internal class Program
    {

        //richu 

        //public class Students
        //{
            
        //    //    public string name;
        //    //    public int age;
        //    //    public int score;
        //}
        

        //adhib


        public class Employee
        {
            public string Name;
            public int Salary;
        }





        static void Main(string[] args)
        {


            //employes :



            //List<Employee> employee= new List<Employee> (){
            //    new Employee { Name="shanif",Salary=70000},
            //    new Employee { Name="Sidha",Salary=55000},
            //    new Employee { Name="adithya",Salary=100000}
            //};

            //var highestpaisemployee = employee.OrderByDescending(e => e.Salary).First();

            //Console.WriteLine($"employee with highest salary : {highestpaisemployee.Name},salary:{highestpaisemployee.Salary}");


            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var data = numbers.GroupBy(x => x % 2 == 0 ? "even" : "odd");
                foreach(var item in data)
                {
                Console.WriteLine($"{item.Key}");
                    foreach(var i in item)
                    {
                        Console.WriteLine(i);
                    }
                }
                
              



        }
    }
}












