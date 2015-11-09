using System.Collections.Generic;
using System.Linq;
using OdeToFoodConsoleApp.Enums;

namespace OdeToFoodConsoleApp.DAL
{
    public static class Entree
    {
        public static string GetEntrees(IReadOnlyDictionary<int, Dictionary<string, int>> order)
        {
            if (order.ContainsKey((int)DishType.DishTypeEnum.Entree))
            {
                return order[(int)DishType.DishTypeEnum.Entree].FirstOrDefault().Key + (order[(int)DishType.DishTypeEnum.Entree] == order.Last().Value ? "" : ", ");
            }
            return "";
        }
    }
}
