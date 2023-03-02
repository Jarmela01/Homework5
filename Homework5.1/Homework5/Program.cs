using System;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // შემოწმება ნაშთზე

            Console.WriteLine("Gtxovt Shemoiyvanot Rivxvi: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 5 == 1)
            {
                Console.WriteLine("Es Ricxvi Ar Iyofa 5-Ze Unashtod!");
            }
            else
            {
                Console.WriteLine("Es Ricxvi Iyofa 5-Ze Unashtod!");
            }
        }
    }
}
