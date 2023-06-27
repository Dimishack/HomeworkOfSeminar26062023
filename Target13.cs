using System;

namespace HomeworkOfSeminar26062023
{
    /*
     * Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
     * 645 -> 5
     * 78 -> третьей цифры нет
     * 32679 -> 6
     */
    internal class Target13
    {
        internal static void ThirdDigitOfNumber()
        {
            Console.Write("Введите положительное число для вывода его третьей цифры (до 10 цифр): ");
            string number = Console.ReadLine();
            if (!uint.TryParse(number, out _) || number.Length > 9)
                Console.WriteLine("Данное значение либо не является положительным числом, " +
                    "\nили является числом, которое имеет больше 9 цифр!");
            else if (number.Length < 3)
                Console.WriteLine("У числа " + number + " третьей цифры нет");
            else
                Console.WriteLine("У число {0} третьей цифрой является: {1}", number, number[2]);
        }
    }
}
