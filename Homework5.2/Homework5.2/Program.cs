using System;

namespace Homework5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shemoiyvanet Pirveli Ricxvi: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Shemoiyvanet Meore Ricxvi ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Shemoiyvanet Moqmedebis Operatori: ");
            var character = Convert.ToChar(Console.ReadLine());

            if (character == '+')
            {
                Console.WriteLine(number1 + number2);
            }
            else if (character == '*')
            {
                Console.WriteLine(number1 * number2);
            }
            else if (character == '/' && (number1 == 0 || number2 == 0))
            {
                Console.WriteLine("Nulis Da Nulze Gayofa Ar Sheidzleba!");
            }
            else if (number1 > number2) 
            {
                if (character == '-')
                {
                    Console.WriteLine(number1 - number2);
                }
                else if (character == '/')
                {                    
                    Console.WriteLine(number1 / number2);
                }
            }
            else if (number2 > number1)
            {
                if (character == '-')
                {
                    Console.WriteLine(number2 - number1);
                }
                else if (character == '/')
                {
                    Console.WriteLine(number2 / number1);
                }

            }
            else if (character == '/' && (number1 == 0 || number2 == 0))
            {
                Console.WriteLine("Nulis Da Nulze Gayofa Ar Sheidzleba!");
            }
        }
    }
}
