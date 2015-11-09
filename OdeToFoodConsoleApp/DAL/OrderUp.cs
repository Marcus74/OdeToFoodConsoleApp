using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFoodConsoleApp.Data;
using OdeToFoodConsoleApp.staticMethods;

namespace OdeToFoodConsoleApp.DAL
{
    public class OrderUp : IDisposable
    {
        private bool _disposed;

        public Dictionary<int, Dictionary<string, int>> GetOrder(IReadOnlyList<string> req)
        {
            // Create a response object
            var responseDictionary = new Dictionary<int, Dictionary<string,int>>();

            // Check if time of day value is good
            var isMorning = req[0].IsMorningCheck();
            if(isMorning == null)
            {
                responseDictionary = ErrorMessage.AddErrorMessage(responseDictionary);
                return responseDictionary;
            }

            // Get our list of food items from our data source
            var foodList = Dishes.GetFoodList2();

            // Loop through request and add up food items
            foreach (var item in req.Skip(1).Where(n => n != string.Empty))
            {
                int foodListItem;
                int.TryParse(item, out foodListItem);

                // Food Item not found return error
                if (foodListItem > foodList.Count())
                {
                    responseDictionary = ErrorMessage.AddErrorMessage(responseDictionary);
                    return responseDictionary;
                }

                // Grab our Dish 
                var foodItem = foodList[foodListItem];

                // Get the morning or night dish
                var dish = (bool) isMorning ? foodItem.MorningDish : foodItem.NightDish;

                // If this dish is already in our response list then let's increment if we can have more than 1
                // or return on error if not.
                if (responseDictionary.ContainsKey(foodListItem))
                {
                    // Check list of items that can have more than 1
                    if (dish.Equals("potato") || dish.Equals("coffee"))
                        responseDictionary[foodListItem][dish]++;
                    else // else let's error out
                    {
                        responseDictionary = ErrorMessage.AddErrorMessage(responseDictionary);
                        return responseDictionary;
                    }
                }
                else
                {
                    // Else let's add a new dish item to the list
                    responseDictionary.Add(foodListItem, new Dictionary<string, int> { { dish, 1 } });
                }
            }
            // Return our response
            return responseDictionary;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~OrderUp()
        {
            Dispose(false);
        }
    }
}
