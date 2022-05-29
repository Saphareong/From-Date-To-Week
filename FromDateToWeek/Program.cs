using System;

namespace FromDateToWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool uglyvalidation = true;
            DateTime inputtedDate = DateTime.Now;
            while (uglyvalidation)
            {
                try
                {
                    //testing
                    Console.Write("Enter a month: ");
                    int month = int.Parse(Console.ReadLine());
                    if(month < 1 || month > 12)
                    {
                        Console.WriteLine("Please enter a valid month");
                        continue;
                    }
                    Console.Write("Enter a day: ");
                    int day = int.Parse(Console.ReadLine());
                    if (day < 1 || day > 31)
                    {
                        Console.WriteLine("Please enter a valid day");
                        continue;
                    }
                    Console.Write("Enter a year: ");
                    int year = int.Parse(Console.ReadLine());
                    inputtedDate = new DateTime(year, month, day);
                    uglyvalidation = false;
                }
                catch
                {
                    Console.WriteLine("please input valid month day and year.");
                }
            }
            Console.WriteLine("The day of the week you input is " + inputtedDate.DayOfWeek);
            Console.WriteLine("Monday: " + Monday(inputtedDate).ToString("d"));
            Console.WriteLine("Tuesday: " + Tuesday(inputtedDate).ToString("d"));
            Console.WriteLine("Wednesday: " + Wednesday(inputtedDate).ToString("d"));
            Console.WriteLine("Thursday: " + Thursday(inputtedDate).ToString("d"));
            Console.WriteLine("Friday: " + Friday(inputtedDate).ToString("d"));
            Console.WriteLine("Saturday: " + Saturday(inputtedDate).ToString("d"));
            Console.WriteLine("Sunday: " + Sunday(inputtedDate).ToString("d"));
        }

        private static DateTime Monday(DateTime date)//return monday no matter what happend
        {
            int dayname = (int)date.DayOfWeek;
            switch (dayname)
            {
                case 0: return date.AddDays(-6);
                case 1: return date;
                case 2: return date.AddDays(-1);
                case 3: return date.AddDays(-2);
                case 4: return date.AddDays(-3);
                case 5: return date.AddDays(-4);
                case 6: return date.AddDays(-5);
                default: throw new Exception("C# doesn't support this operation no more :(");
            }
        }

        private static DateTime Sunday(DateTime date)//return sunday no matter what happend
        {
            int dayname = (int)date.DayOfWeek;
            switch (dayname)
            {
                case 0: return date;
                case 1: return date.AddDays(6);
                case 2: return date.AddDays(5);
                case 3: return date.AddDays(4);
                case 4: return date.AddDays(3);
                case 5: return date.AddDays(2);
                case 6: return date.AddDays(1);
                default: throw new Exception("C# doesn't support this operation no more :(");
            }
        }

        private static DateTime Tuesday(DateTime date)
        {
            int dayname = (int)date.DayOfWeek;
            switch (dayname)
            {
                case 0: return date.AddDays(-5).Date;
                case 1: return date.AddDays(1).Date;
                case 2: return date.Date;
                case 3: return date.AddDays(-1).Date;
                case 4: return date.AddDays(-2).Date;
                case 5: return date.AddDays(-3).Date;
                case 6: return date.AddDays(-4).Date;
                default: throw new Exception("C# doesn't support this operation no more :(");
            }
        }

        private static DateTime Wednesday(DateTime date)
        {
            int dayname = (int)date.DayOfWeek;
            switch (dayname)
            {
                case 0: return date.AddDays(-4).Date;
                case 1: return date.AddDays(2).Date;
                case 2: return date.AddDays(1).Date;
                case 3: return date.Date;
                case 4: return date.AddDays(-1).Date;
                case 5: return date.AddDays(-2).Date;
                case 6: return date.AddDays(-3).Date;
                default: throw new Exception("C# doesn't support this operation no more :(");
            }
        }

        private static DateTime Thursday(DateTime date)
        {
            int dayname = (int)date.DayOfWeek;
            switch (dayname)
            {
                case 0: return date.AddDays(-3).Date;
                case 1: return date.AddDays(3).Date;
                case 2: return date.AddDays(2).Date;
                case 3: return date.AddDays(1).Date;
                case 4: return date.Date;
                case 5: return date.AddDays(-1).Date;
                case 6: return date.AddDays(-2).Date;
                default: throw new Exception("C# doesn't support this operation no more :(");
            }
        }

        private static DateTime Friday(DateTime date)
        {
            int dayname = (int)date.DayOfWeek;
            switch (dayname)
            {
                case 0: return date.AddDays(-2).Date;
                case 1: return date.AddDays(4).Date;
                case 2: return date.AddDays(3).Date;
                case 3: return date.AddDays(2).Date;
                case 4: return date.AddDays(1).Date;
                case 5: return date.Date;
                case 6: return date.AddDays(-1).Date;
                default: throw new Exception("C# doesn't support this operation no more :(");
            }
        }

        private static DateTime Saturday(DateTime date)
        {
            int dayname = (int)date.DayOfWeek;
            switch (dayname)
            {
                case 0: return date.AddDays(-1).Date;
                case 1: return date.AddDays(5).Date;
                case 2: return date.AddDays(4).Date;
                case 3: return date.AddDays(3).Date;
                case 4: return date.AddDays(2).Date;
                case 5: return date.AddDays(1).Date;
                case 6: return date.Date;
                default: throw new Exception("C# doesn't support this operation no more :(");
            }
        }
    }
}
