/*
 * for rectangle
 * Console.WriteLine("Enter the 2 sides of rectangle");
var oneSide = int.Parse(Console.ReadLine());
var secondSide = int.Parse(Console.ReadLine());
Console.WriteLine($"Area of rectangle is {oneSide * secondSide}");
Console.WriteLine($"Perimeter of the rectangle is {oneSide*2 + secondSide*2}");
*/

/*Console.WriteLine("Enter triangle sides");
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());
int Perimeter = a+b+c;
Console.WriteLine($"Here is the perimeter of triangle: {Perimeter}");
int semiperimeter = Perimeter / 2;
var area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
Console.WriteLine($"The are of the triagnle is {area}");
*/

Console.WriteLine("Please input the radius of the circle");
var radius = int.Parse(Console.ReadLine());
int diameter = radius * 2;
Console.WriteLine($"The diameter of the circle is: {diameter}");
var area = 2 * Math.PI * radius;
Console.WriteLine($"The area of the circle is {area}");