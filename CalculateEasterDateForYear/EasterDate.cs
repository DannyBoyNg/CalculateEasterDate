using System;

namespace CalculateEasterDateForYear
{
    public class EasterDate
    {
        public static DateTime GetDateForYear(int? yearArg = null)
        {
            int year;
            year = (yearArg == null) ? DateTime.Now.Year : year = yearArg.Value;
            int day = 0;
            int month = 0;

            int g = year % 19;
            int c = year / 100;
            int h = (c - c / 4 - (8 * c + 13) / 25 + 19 * g + 15) % 30;
            int i = h - h / 28 * (1 - h / 28 * (29 / (h + 1)) * ((21 - g) / 11));

            day = i - ((year + year / 4 + i + 2 - c + c / 4) % 7) + 28;
            month = 3;
            if (day > 31)
            {
                month++;
                day -= 31;
            }
            return new DateTime(year, month, day);
        }
    }
}
