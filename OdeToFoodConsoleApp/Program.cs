using System;
using OdeToFoodConsoleApp.DAL;
using OdeToFoodConsoleApp.DI;
using OdeToFoodConsoleApp.staticMethods;
using OdeToFoodConsoleApp.View;

namespace OdeToFoodConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            // Set output Writer
            Writer.SetWriter<ConsoleOutput>();
            //Writer.SetWriter<ConsoleOutputChristmas>();
 
            // Prompt for input
            Console.Write("Input: ");
            var input = Console.ReadLine();

            // Remove spaces and split on commas
            var req = input?.Replace(" ", "")
                            .Split(',');

            // Check if the user entered a usuable order, exit if not
            if (req == null || req.Length < 2)
            {
                Writer.WriteOutput("Output: error(\"At least one selection is required!\") ");
            }
            else
                using (var order = new OrderUp())
                {
                    // Store order in buckets
                    var response = order.GetOrder(req);

                    // Parse order to a string
                    var res = Parser.ParseOrders(response);

                    // Print order
                    Writer.WriteOutput(res);
                }

            // Wait for user to press a key and exit
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
