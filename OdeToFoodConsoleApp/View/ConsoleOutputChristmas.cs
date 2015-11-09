using System;
using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.View
{
    public class ConsoleOutputChristmas : IOutput
    {
        public void WriteLine(string line)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(line);
            Console.ResetColor();
        }
    }
}
