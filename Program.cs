using System;

namespace HomeworkOfSeminar26062023
{
    internal class Program
    {
        static void Main()
        {
			try
			{
                Console.WriteLine("Задача №15:");
                Target15.DayOfWeek();
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