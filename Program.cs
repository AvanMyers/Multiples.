using System;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minRandom = 10;
            int maxRandom = 25;
            int minSearchNumber = 50;
            int maxSearchNumber = 150;
            int multipleNumber = 0;

            Random random = new Random();
            number = random.Next(minRandom, maxRandom + 1);

            for (int i = number; i < maxSearchNumber; i += number)
            {
                if (i >= minSearchNumber)
                {
                    multipleNumber++;
                }
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {number} равно {multipleNumber}");
            Console.ReadKey();
        }
    }
}
