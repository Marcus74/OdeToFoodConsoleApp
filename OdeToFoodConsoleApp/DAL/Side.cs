using System.Collections.Generic;
using System.Linq;
using OdeToFoodConsoleApp.Enums;

namespace OdeToFoodConsoleApp.DAL
{
    public class Side
    {
        public static string GetSides(IReadOnlyDictionary<int, Dictionary<string, int>> order)
        {
            if (!order.ContainsKey((int)DishType.DishTypeEnum.Side)) return "";
            var key = order[(int)DishType.DishTypeEnum.Side].FirstOrDefault().Key;
            var keyValue = order[(int)DishType.DishTypeEnum.Side].FirstOrDefault().Value;
            return order[(int)DishType.DishTypeEnum.Side].FirstOrDefault().Key +
                   (key.Equals("potato") && keyValue > 1 ? "(x" + order[(int)DishType.DishTypeEnum.Side].FirstOrDefault().Value + ")" : "")
                   + (order[(int)DishType.DishTypeEnum.Side] == order.Last().Value ? "" : ", ");
        }

    }
}
