using System;
using FibonacciTools;

namespace ConsoleApp1
{
	class Program
	{
        static void Main(string[] args)
        {
            int i = 0;
            while (i >= 0)
            {
                Console.Write("Insert an integer (-1 to exit): ");
                i = int.Parse(Console.ReadLine());

                if (i >= 0)
                {
                    Console.Write("Your Fibonnaci is: ");
                    Console.WriteLine(Fibonacci.GetNumber(i));
                    Console.WriteLine("");
                }
            }
        }
    }
}
