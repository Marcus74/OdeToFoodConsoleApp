using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.DishTypes
{
    public class Dessert : IFoodItem
    {
        public int Count { get; set; } = 1;
        string IFoodItem.MorningDish { get; set; } = "error";
        string IFoodItem.NightDish { get; set; } = "cake";
    }
}
