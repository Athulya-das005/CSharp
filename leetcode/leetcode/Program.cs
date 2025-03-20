namespace leetcode
{
    internal class Program
    {

        static int SingleNumber(int[] array)
        {
            return array.GroupBy(x => x).Where(y => y.Count() == 1).Select(z =>z.Key).First();

        }
        static void Main(string[] args)
        { 
            int[]array1 = {1,3,2,4,5,1,3,4,5};
            int []arr2 = { 65, 43, 65, 88, 65, 43 };
            int[] arr3 = { 0, 0, 1, 4, 0, 1, };
            Console.WriteLine(SingleNumber(array1));
            Console.WriteLine(SingleNumber(arr2));
            Console.WriteLine(SingleNumber(arr3));




        }
    }
}


