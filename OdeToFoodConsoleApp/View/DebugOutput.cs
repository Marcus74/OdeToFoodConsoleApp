using System.Diagnostics;
using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.View
{
    public class DebugOutput : IOutput
    {
        public void WriteLine(string line)
        {
            Debug.WriteLine(line);
        }
    }
}
