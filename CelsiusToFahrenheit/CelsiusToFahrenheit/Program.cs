using System;

namespace CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in celsius to convert to fahrenheit.");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 9/5 + 32;

            Console.WriteLine($"The temperature in fahrenheit is {fahrenheit:f2}");




        }
    }
}
