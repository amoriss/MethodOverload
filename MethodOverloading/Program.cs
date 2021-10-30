using System;

namespace MethodOverloading
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool c)
        {
            int total = a + b;
            if (c && total > 1 || total < 1)
            {
                return ($"The sum is: ${total} dollars");
            }
            if (c && total == 1)
            {
                return ($"The sum is: ${total} dollar");
            }
         
          return $"{total}";            

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading");
            Console.WriteLine("5 + 5 = " + Add(5, 5));
            Console.WriteLine("4.5432m + 5432.43434m = " + Add(4.5432m, 5432.43434m));
            Console.WriteLine("$7 + 7 + true = "+ Add(7, 7, true));  // ($"The sum is: 14 dollars");
            Console.WriteLine("$0 + $1 + true = "+ Add(0, 1, true)); // ($"The sum is: 1 dollar");
            Console.WriteLine("$5 + $5 + false = " + Add(5, 5, false)); // return $"10";


        }
    }
}
