using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.DishTypes
{
    public class Drink : IFoodItem
    {
        public int Count { get; set; } = 1;
        string IFoodItem.MorningDish { get; set; } = "coffee";
        string IFoodItem.NightDish { get; set; } = "wine";
    }
}
