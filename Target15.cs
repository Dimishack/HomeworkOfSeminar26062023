using System;

namespace HomeworkOfSeminar26062023
{
    /*
     * Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
     * 6 -> да
     * 7 -> да
     * 1 -> нет
     */
    internal class Target15
    {
        internal static void DayOfWeek()
        {
            ConsoleKey key;
            do
            {
                string[] dayOfWeeks = { "Понедельник", "Вторник", "Среда", "Четверг",
                                    "Пятница", "Суббота", "Воскресенье" };

                Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
                string digitForDayOFWeek = Console.ReadLine();
                if (digitForDayOFWeek.Length == 1 && digitForDayOFWeek != "0"
                    && sbyte.TryParse(digitForDayOFWeek, out sbyte digit))
                {
                    Console.WriteLine("Цифра {0} является днем недели: {1}", digit, dayOfWeeks[digit - 1]);
                    Console.WriteLine((digit > 5) ? "И он является выходным днем" : "И он не является выходным днем");
                }
                else
                    Console.WriteLine("Данное значение не является цифрой, обозначающей день недели!");

                Console.WriteLine("\nEnter - Вернуться к журналу \nЛюбая другая клавиша - решить заново");
                Console.Write("Выберите действие: ");
                key = Console.ReadKey().Key;
                Console.WriteLine();
            } while (key != ConsoleKey.Enter);
        }
    }
}
