using System;

namespace AreaOfTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of triangle");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter one side of the triangle");
            double side = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of triangle is " + side * height / 2);
        }
    }
}
