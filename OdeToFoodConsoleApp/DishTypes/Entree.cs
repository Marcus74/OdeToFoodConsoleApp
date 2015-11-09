using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.DishTypes
{
    public class Entree : IFoodItem
    {
        public int Count { get; set; } = 1;
        string IFoodItem.MorningDish { get; set; } = "eggs";
        string IFoodItem.NightDish { get; set; } = "steak";
    }
}
