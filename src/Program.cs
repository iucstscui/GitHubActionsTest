using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; ++i)
            {
                Console.WriteLine(FizzBuzz(i));
            }
        }

        public static string FizzBuzz(int num)
        {
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
