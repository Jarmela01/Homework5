using System;

namespace Homework5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            a = c - a;
            b = c - b;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
