using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1988, 5, 31);

            Console.WriteLine("My birthday is {0}", dateTime);

            // write today on scree
            Console.WriteLine(DateTime.Today);
            // write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

            int year = 1999;
            Console.WriteLine("First day of year {0} is {1}", year, GetFirstDayOfYear(year));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}", days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.WriteLine("Write your birthday date in this format: yyyy-mm-dd");
            input = Console.ReadLine();

            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassedBirthday = now.Subtract(dateTime);
                Console.WriteLine("Days passed since your birthday: {0}", daysPassedBirthday.Days);
            }

            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
