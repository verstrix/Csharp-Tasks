using System;

namespace TheWeatherOutside
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weather = Console.ReadLine();

            if (weather == "sunny")
            {
                Console.WriteLine("It's warm!");
            }
            else
            {
                Console.WriteLine("It's cold!");
            }
        }
    }
}
