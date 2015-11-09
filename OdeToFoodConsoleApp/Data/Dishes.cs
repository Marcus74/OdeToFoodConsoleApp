using System;
using System.Collections.Generic;
using OdeToFoodConsoleApp.DishTypes;
using OdeToFoodConsoleApp.Enums;
using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.Data
{
    public class Dishes
    {
        //public static Dictionary<int, Tuple<string, string>> GetFoodList()
        //{
        //    return new Dictionary<int, Tuple<string, string>>()
        //    {
        //        {(int)DishType.DishTypeEnum.Entree, new Tuple<string, string>("Eggs", "Steak")},
        //        {(int)DishType.DishTypeEnum.Side, new Tuple<string, string>("Toast", "Potato")},
        //        {(int)DishType.DishTypeEnum.Drink, new Tuple<string, string>("Coffee", "Wine")},
        //        {(int)DishType.DishTypeEnum.Dessert, new Tuple<string, string>("Error", "Cake")} 
        //    };
        //}

        public static Dictionary<int, IFoodItem> GetFoodList2()
        {
            return new Dictionary<int, IFoodItem>()
            {
                {(int) DishType.DishTypeEnum.Entree, new Entree()},
                {(int) DishType.DishTypeEnum.Side, new Side()},
                {(int) DishType.DishTypeEnum.Drink, new Drink()},
                {(int) DishType.DishTypeEnum.Dessert, new Dessert()}
            };
        }
    }
}
