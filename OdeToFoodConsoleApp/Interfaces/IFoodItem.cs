namespace OdeToFoodConsoleApp.Interfaces
{
    public interface IFoodItem
    {
        int Count { get; set; }
        string MorningDish { get; set; }
        string NightDish { get; set; }
    }
}
