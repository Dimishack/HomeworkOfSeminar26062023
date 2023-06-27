using System;

namespace HomeworkOfSeminar26062023
{
    internal class Program
    {
        static void Main()
        {
			try
			{
                Console.WriteLine("Задача №13:");
                Target13.ThirdDigitOfNumber();
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
                throw;
			}
            finally 
            {
                Console.WriteLine("\nДля выхода из программы нажмите на любую клавишу...");
                Console.ReadKey(true);
            }
        }
    }
}