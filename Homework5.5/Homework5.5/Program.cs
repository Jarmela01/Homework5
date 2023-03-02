using System;

namespace Homework5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sheiyvanet Ricxvi:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Tqveni Shemoyvanili Ricxvia" + number);
                    Console.WriteLine($"{i} X {i} = " + i*i);
                }
            }
        }
    }
}
