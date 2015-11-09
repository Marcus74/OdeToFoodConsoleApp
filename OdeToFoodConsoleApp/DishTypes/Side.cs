using OdeToFoodConsoleApp.Interfaces;

namespace OdeToFoodConsoleApp.DishTypes
{
    public class Side : IFoodItem
    {
        public int Count { get; set; } = 1;
        string IFoodItem.MorningDish { get; set; } = "toast";
        string IFoodItem.NightDish { get; set; } = "potato";
    }
}
