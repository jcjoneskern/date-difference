using System;
using System.Globalization;

namespace date_difference
{
    class DateDiff
    {
        public DateTime getDate()
        {
            Console.WriteLine("Enter a date (mm/dd/yyyy):");
            String date = Console.ReadLine();

            while (!(DateTime.TryParseExact(date, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out DateTime result)))
            {
                Console.WriteLine("That is not a valid date. Enter a date (mm/dd/yyyy):");
                date = Console.ReadLine();
            }

            DateTime parsedDate = DateTime.ParseExact(date, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None);

            return parsedDate;
        }


        static void Main(string[] args)
        {
            DateDiff d = new DateDiff();

            DateTime date1 = d.getDate(), date2 = d.getDate();

            TimeSpan dateRange = (date1 - date2);

            double totalDays = dateRange.TotalDays, totalHours = dateRange.TotalHours, totalMinutes = dateRange.TotalMinutes;

            Console.WriteLine("There are {0} days, or {1} hours, or {2} minutes between {3:d} and {4:d}", Math.Abs(totalDays), Math.Abs(totalHours), Math.Abs(totalMinutes), date1, date2);

            Console.ReadKey();
        }
    }
}
