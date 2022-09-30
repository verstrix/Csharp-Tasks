using System;
using System.Transactions;

namespace GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter two numbers");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            
            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }



        }
    }
}
