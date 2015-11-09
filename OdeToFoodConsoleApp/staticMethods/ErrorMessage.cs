using System.Collections.Generic;

namespace OdeToFoodConsoleApp.staticMethods
{
    static class ErrorMessage
    {
        public static Dictionary<int, Dictionary<string, int>> AddErrorMessage(Dictionary<int, Dictionary<string, int>> responseDictionary)
        {
            const string error = "error";
            const int ierror = 99;
            if (responseDictionary.ContainsKey(ierror))
            {
                responseDictionary[ierror][error]++;
            }
            else
            {
                responseDictionary.Add(ierror, new Dictionary<string, int> { { error, 1 } });
            }

            return responseDictionary;
        }
    }
}
