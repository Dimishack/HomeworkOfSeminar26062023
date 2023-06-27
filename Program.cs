using System;

namespace HomeworkOfSeminar26062023
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                ConsoleKey key;
                do
                {
                    Console.WriteLine("Добро пожаловать в программу \"Домашнее задание семинара 26.06.2023\"");
                    Console.WriteLine("1. Задача 10: Напишите программу, которая принимает на вход трёхзначное число" +
                                        " и на выходе показывает вторую цифру этого числа." +
                                        "\n2. Задача 13: Напишите программу, которая выводит третью цифру заданного числа или " +
                                        "сообщает, что третьей цифры нет. До 10 символов" +
                                        "\n3. Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, " +
                                        "и проверяет, является ли этот день выходным." +
                                        "\n4. Дополнительная задача: Назовём число «интересным» если его произведение цифр делится " +
                                        "на их сумму БЕЗ остатка.Напишите программу, которая заполняет массив на 10 «интересных» " +
                                        "случайных целых чисел от 10 до 1000(999 - последнее) (каждый эл-т массива – сгенерирован случайно)" +
                                        "\nEnter - Выход из программы");
                    Console.Write("Нажмите на клавишу (цифру), чтобы перейти к задаче или выйти из программы: ");
                    key = Console.ReadKey().Key;
                    Console.WriteLine('\n');
                    switch (key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Target10.SecondDigitOfNumber();
                            Console.Clear();
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Target13.ThirdDigitOfNumber();
                            Console.Clear();
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Target15.DayOfWeek();
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            AdditionalTask.FindInterestingNumbers();
                            Console.Clear();
                            break;
                        case ConsoleKey.Enter:
                            break;
                        default:
                            Console.WriteLine("Данная клавиша в журнал не добавлена!");
                            Console.SetCursorPosition(0, 0);
                            break;
                    }
                } while (key != ConsoleKey.Enter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nДля выхода из программы нажмите на любую клавишу...");
                Console.ReadKey(true);
            }
        }
    }
}