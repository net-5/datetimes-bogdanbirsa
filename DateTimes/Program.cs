using System;
using System.Globalization;

namespace DateTimesHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //a) current date and time - another version
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //b)current year - another version
            Console.WriteLine(now.ToString("yyyy"));

            //c)month of year - another version
            Console.WriteLine(now.ToString("MMM"));

            //f) day of the year - another version
            Console.WriteLine(now.DayOfYear);

            //h) Day of the week
            Console.WriteLine(now.DayOfWeek);

            InfoDates(); // create a method with exercise 1
            AddNYears(2); //adding 2 years to the curent date
            DisplayFriendlyTime();
            AddFive();
            GetTimeMilliseconds();
            AddSixMonths();
            FirstLastSecondOfDay();
            TwoDifferentDate();
            CalculateAge();
            GetDates();
            DaysBetweenTwoDates();
            PrintDays();
            PrintNextFiveDays();
            Interval();
            Sundays();
            */
            Console.WriteLine($"The date for the first Monday of the week 50 is {FirstMonday()}");
        }

        public static void InfoDates()
        {
            /*  
           Write a program to display the:
           a) Current date and time
           b) Current year
           c) Month of year
           d) Week number of the year
           e) Weekday of the week
           f) Day of year
           g) Day of the month
           h) Day of week
           j) if the current year is a leap year or not
           */
            DateTime actualDate = new DateTime();
            actualDate = DateTime.Now;

            //a)
            Console.WriteLine($"Current date and time: {actualDate.ToString()}");
            //b)
            Console.WriteLine($"Current year: {actualDate.Year}");
            //c)
            Console.WriteLine($"Month of the year: {actualDate.Month}");
            //d)
            Console.WriteLine($"Week number of the year:" + CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday));
            //e)
            Console.WriteLine($"Weekday of the week: {actualDate.DayOfWeek}");
            //f)
            Console.WriteLine($"Day of year: {actualDate.DayOfYear}");
            //g)
            Console.WriteLine($"Day of the month: {actualDate.Day}");
            //h)
            Console.WriteLine($"Day of week: {actualDate.DayOfWeek}");
            //j)
            if (DateTime.IsLeapYear(actualDate.Year))
            {
                Console.WriteLine("Current year is leap");
            }
            else
            {
                Console.WriteLine("Current year is not leap");
            }
        }

        //2. Write a program to add N year(s) to the current date and display the new date
        public static void AddNYears(int N)
        {
            DateTime actualDate = new DateTime();
            actualDate = DateTime.Now;
            DateTime newDate;
            newDate = actualDate.AddYears(N);
            Console.WriteLine($"The new date after adding {N} is {newDate}");
        }

        //3. Write a program to display the date and time in a human-friendly string.
        public static void DisplayFriendlyTime()
        {
            DateTime actualDate = new DateTime();
            Console.WriteLine($" The time is {DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}");
        }

        //4. Write a program to add 5 seconds to the current time and print it to the console.
        public static void AddFive()
        {
            DateTime actualDate = DateTime.Now;
            DateTime newTime = actualDate.AddSeconds(5);
            Console.WriteLine($"Current date and time is:{actualDate} and after 5 seconds will be {actualDate.AddSeconds(5)} ");
        }

        //5. Write a program to get current time in milliseconds
        public static void GetTimeMilliseconds()
        {
            DateTime actualDate = DateTime.Now;
            double newTime2 = (DateTime.Now - DateTime.MinValue).TotalMilliseconds;
            Console.WriteLine(newTime2);
        }

        //6. Write a program that calculates the date six months from the current date.
        public static void AddSixMonths()
        {
            DateTime actualDate = DateTime.Now;
            DateTime newTime3 = actualDate.AddMonths(6);
            Console.WriteLine($"Current date is {actualDate} and after adding 6 months will be {newTime3}");
        }

        //7. Write a program to get the first and last second of a day.
        public static void FirstLastSecondOfDay()
        {
            DateTime actualDate = DateTime.Now;
            DateTime firstSec = actualDate.Date.AddSeconds(1);
            DateTime lastSec = actualDate.Date.AddDays(1).AddTicks(-1);
            Console.WriteLine($"First second of day is {firstSec} and the last second of the day is {lastSec}");
        }

        //8. Write a program to calculate two date difference in seconds.
        public static void TwoDifferentDate()
        {
            DateTime actualDate = DateTime.Now;
            DateTime firstDate = actualDate.Date;
            DateTime secondDate = DateTime.Now.AddMonths(-6);
            var diffInSeconds = (firstDate - secondDate).TotalSeconds;
            Console.WriteLine(diffInSeconds);
        }

        //9. Given a date of birth, calculate the age of a person.
        //Input: 10, 09, 1989 
        //Output: 29

        public static void CalculateAge()
        {
            DateTime dateOfBirth = new DateTime(1989, 09, 10);
            DateTime actualDate = DateTime.Now;
            int age = (actualDate.Year - dateOfBirth.Year) - 1;
            Console.WriteLine(age);
        }

        //10. Write a program to get the dates 30 days before and after from the current date, and display it to the console
        public static void GetDates()
        {
            DateTime acualDate = DateTime.Now;
            DateTime firstThirty = DateTime.Now.AddDays(30);
            DateTime secondThirty = DateTime.Now.AddDays(-30);
            Console.WriteLine($"The date 30 days before curent date is {secondThirty} and the date 30 days after current date is {firstThirty}");
        }

        //11. Write a program to calculate a number of days between two dates.
        public static void DaysBetweenTwoDates()
        {
            DateTime first = new DateTime(2019, 05, 12);
            DateTime second = new DateTime(2010, 02, 05);
            double differenceDays = (first - second).TotalDays;
            Console.WriteLine($" Difference between date {first} and date {second} are {differenceDays} days");
        }

        //12. Write a program to print yesterday, today, tomorrow.
        //Yesterday :  2017-05-05 
        //Today :  2017-05-06                  
        //Tomorrow :  2017-05-0

        public static void PrintDays()
        {
            DateTime yesterday = DateTime.Now.AddDays(-1);
            DateTime today = DateTime.Now;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            Console.WriteLine($"Yesterday date is {yesterday}. Today date is {today}. Tommorow date is {tomorrow}");
        }

        //13. Write program to print next 5 days starting from today.

        public static void PrintNextFiveDays()
        {
            DateTime today = DateTime.Today; // get current day
            TimeSpan plusOneDay = new TimeSpan(1, 1, 1, 1); //add another 4 days to the current using TimeSpan
            for (int i = 0; i < 5; i++) //use forloop to get next 4 days
            {
                today += plusOneDay;
                Console.WriteLine($" Print day {i + 1} - {today}");
            }
        }

        

        //15.Write a program to get days between two dates.
        //Input :2000,2,2
        //2001,2,28
        //Output : 366 days, 0:00:00
        static void Interval()
        {
            DateTime data1 = new DateTime(2000, 02, 02);
            DateTime data2 = new DateTime(2001, 02, 28);
            TimeSpan interval = data2 - data1;
            Console.WriteLine($" Difference between {data2} and {data1} is {interval.Days} days");

        }

        //16.Write a program to select all the Sundays of a specified year and display their dates
        //Output:
        //2020-01-05
        //2020-01-12 
        //2020-01-19
        static void Sundays()
        {
            DateTime beginDate = new DateTime(2018, 01, 01);
            DateTime endDate = new DateTime(2018, 12, 31);
            TimeSpan diff = endDate - beginDate;
            int days = diff.Days;
            for (var i = 0; i <= days; i++)
            {
                var anotherDate = beginDate.AddDays(i);
                switch (anotherDate.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        Console.WriteLine(anotherDate.ToShortDateString());
                        break;
                }
            }
            Console.ReadLine();
        }

        //14. Write a program to find the date of the first Monday of a given week
        //Input  : 2015, 50
        // Output : Mon Dec 14 00:00:00 2015      

        static DateTime FirstMonday()
        {
            int year = 2015;
            int weekOfYear = 50;
            DateTime jan1 = new DateTime(year, 1, 1);
            int days = DayOfWeek.Thursday - jan1.DayOfWeek;
            DateTime firstMonday = jan1.AddDays(days);
            var calendar = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = calendar.GetWeekOfYear(firstMonday, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            var weekNum = weekOfYear;
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }
            var result = firstMonday.AddDays(weekNum * 7);
            return result.AddDays(+4);
        }
    }
}
