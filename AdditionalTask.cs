using System;
using System.Diagnostics;

namespace HomeworkOfSeminar26062023
{
    /*
     * Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. 
     * Напишите программу, которая заполняет массив на 10 «интересных» 
     * случайных целых чисел от 10 до 1000(999 - последнее). 
     * (каждый эл-т массива – сгенерирован случайно)
     * Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15;
     * произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
     * [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
     */
    internal class AdditionalTask
    {
        internal static void FindInterestingNumbers()
        {
            ConsoleKey key;
            do
            {
                Random random = new Random();
                string[] interestingNumbers = new string[10];
                Console.WriteLine("Интересные числа: ");
                for (int i = 0; i < interestingNumbers.Length;)
                {
                    string number = random.Next(10, 1000).ToString();
                    if (Array.IndexOf(interestingNumbers, number) != -1)
                        continue;
                    int resultSum = Convert.ToInt32(number[0] - '0');
                    int resultMult = Convert.ToInt32(number[0] - '0');
                    for (int j = 1; j < number.Length; j++)
                    {
                        resultSum += Convert.ToInt32(number[j] - '0');
                        resultMult *= Convert.ToInt32(number[j] - '0');
                    }
                    if (resultMult % resultSum == 0)
                    {
                        interestingNumbers[i] = number;
                        Console.Write(number);
                        if (i < interestingNumbers.Length - 1) Console.Write(", ");
                        i++;
                    }
                }

                Console.WriteLine(  "\nEnter - Вернуться к журналу \nC - Открыть калькулятор и решить заново " +
                                    "\nЛюбая другая клавиша - решить заново");
                Console.Write("Выберите действие: ");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.C)
                    Process.Start("calc");
                Console.WriteLine('\n');
            } while (key != ConsoleKey.Enter);
        }
    }
}
