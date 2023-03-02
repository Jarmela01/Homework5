using System;

namespace Homework5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{number} X {i} = " + number * i);
            }
        }
    }
}
