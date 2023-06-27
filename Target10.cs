using System;

namespace HomeworkOfSeminar26062023
{
    /*
     * Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
     * 456 -> 5
     * 782 -> 8
     * 918 -> 1
     */
    internal class Target10
    {
        internal static void SecondDigitOfNumber()
        {
            Console.Write("Введите трехзначное положительное число для вывода его второй цифры: ");
            string number = Console.ReadLine();
            if (!ushort.TryParse(number, out _) || number.Length != 3)
                Console.WriteLine("Данное значение не является трехзначным положительным числом!");
            else 
                Console.WriteLine("Вторая цифра трехзначного числа {0} является: {1}", number, number[1]);
        }
    }
}
