using System;
using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.View
{
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
