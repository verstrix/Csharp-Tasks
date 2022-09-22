Console.WriteLine("Type the three sides of triangle");
var sideA = int.Parse(Console.ReadLine());
var sideB = int.Parse(Console.ReadLine());
var sideC = int.Parse(Console.ReadLine());
if (sideA == sideB || sideB == sideC || sideC == sideA)
{
    Console.WriteLine("Two of the sides are equal");
}
else
{
    Console.WriteLine("No equal sides");
}

if (sideA == sideB && sideB == sideC && sideC == sideA)
{
    Console.WriteLine("All of the sides are equal");
}
else if (sideA == sideB)
{
    Console.WriteLine("Side A and B are equal");
}
else if (sideB == sideC)
{
    Console.WriteLine("Side C and B are equal");
}

else if (sideC == sideA)
{
    Console.WriteLine("Side A and C are equal");
}


