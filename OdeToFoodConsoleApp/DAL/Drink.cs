using System.Collections.Generic;
using System.Linq;
using OdeToFoodConsoleApp.Enums;

namespace OdeToFoodConsoleApp.DAL
{
    public class Drink
    {
        public static string GetDrinks(IReadOnlyDictionary<int, Dictionary<string, int>> order)
        {
            if (!order.ContainsKey((int)DishType.DishTypeEnum.Drink)) return "";
            var key = order[(int)DishType.DishTypeEnum.Drink].FirstOrDefault().Key;
            var keyValue = order[(int)DishType.DishTypeEnum.Drink].FirstOrDefault().Value;
            return order[(int)DishType.DishTypeEnum.Drink].FirstOrDefault().Key +
                (key.Equals("coffee") && keyValue > 1 ? "(x" + order[(int)DishType.DishTypeEnum.Drink].FirstOrDefault().Value + ")" : "")
                + (order[(int)DishType.DishTypeEnum.Drink] == order.Last().Value ? "" : ", ");
        }

    }
}
