using System;

namespace AreaAndPerimeterOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"The perimeter of the circle is {perimeter:f2}");
            Console.WriteLine($"The area of the circle is {area:f2}");


        }
    }
}
