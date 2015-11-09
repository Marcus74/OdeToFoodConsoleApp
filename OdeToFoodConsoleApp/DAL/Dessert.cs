using System.Collections.Generic;
using System.Linq;
using OdeToFoodConsoleApp.Enums;

namespace OdeToFoodConsoleApp.DAL
{
    public class Dessert
    {
        public static string GetDesserts(IReadOnlyDictionary<int, Dictionary<string, int>> order)
        {
            if (order.ContainsKey((int)DishType.DishTypeEnum.Dessert))
            {
                return order[(int)DishType.DishTypeEnum.Dessert].FirstOrDefault().Key + (order[(int)DishType.DishTypeEnum.Dessert] == order.Last().Value ? "" : ", ");
            }
            return "";
        }
    }
}
