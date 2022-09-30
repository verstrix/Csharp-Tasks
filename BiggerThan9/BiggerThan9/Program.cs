using System;
using System.Net.Http.Headers;

namespace BiggerThan9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("One");
            }
            if (number == 2)
            {
                Console.WriteLine("Two");
            }
            if (number == 3)
            {
                Console.WriteLine("Three");
            }
            if (number == 4)
            {
                Console.WriteLine("Four");
            }
            if (number == 5)
            {
                Console.WriteLine("Five");
            }
            if (number == 6)
            {
                Console.WriteLine("Six");
            }
            if (number == 7)
            {
                Console.WriteLine("Seven");
            }
            if (number == 8)
            {
                Console.WriteLine("Eight");
            }
            if (number == 9)
            {
                Console.WriteLine("Nine");
            }
            if (number > 9)
            {
                Console.WriteLine("Too big");
            }

        }
    }
}
