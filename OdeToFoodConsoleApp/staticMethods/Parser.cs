using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFoodConsoleApp.DAL;

namespace OdeToFoodConsoleApp.staticMethods
{
    public class Parser
    {
        public static string ParseOrders(Dictionary<int, Dictionary<string, int>> order)
        {
            // Our string buffer
            var sb = new StringBuilder("Output: ");

            // Get Entrees
            sb.Append(Entree.GetEntrees(order));

            // Get Sides
            sb.Append(Side.GetSides(order));

            // Get Drinks
            sb.Append(Drink.GetDrinks(order));

            // Get Desserts
            sb.Append(Dessert.GetDesserts(order));

            // Get errors
            if (order.ContainsKey(99))
            {
                sb.Append(order[99].FirstOrDefault().Key);
            }
            return sb.ToString();
        }
    }
}
