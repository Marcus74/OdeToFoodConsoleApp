using System;
using OdeToFoodConsoleApp.Enums;

namespace OdeToFoodConsoleApp.staticMethods
{
    public static class CheckTimeOfDay
    {
        public static bool? IsMorningCheck(this string s)
        {
            TimeOfDay.TimeOfDayEnum timeOfDay;
            if (!Enum.TryParse(s, true, out timeOfDay)) return null;
            switch (timeOfDay)
            {
                case TimeOfDay.TimeOfDayEnum.Morning:
                    return true;
                case TimeOfDay.TimeOfDayEnum.Night:
                    return false;
            }
            return null;
        }
    }
}
