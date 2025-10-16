using System.Globalization;

namespace Helper
{
    internal class DateTimeHelper
    {
        public static DateTime GetValidDate(string query)
        {
            CultureInfo culture = new CultureInfo("nl-BE");
            DateTime date;
            while (true)
            {
                try
                {
                    string userGivenDate = UserInputHelper.StringInput(query);
                    date = DateTime.Parse(userGivenDate, culture);
                    break;

                }
                catch
                {
                    Console.WriteLine("Invalid date. Please try again.");
                    continue;
                }
            }
            return date;
        }
    }
}
