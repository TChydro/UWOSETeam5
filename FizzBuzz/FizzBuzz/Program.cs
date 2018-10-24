using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            for (int i = 1; i <= number; i++)
            {
            // ANOTHER CHANGE
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
             // CHANGE   
            }
        }
    }
}
