using System;
using System.Globalization;

namespace DateRange
{
    public class Date
    {
        public static void GenerateDate(string[] args, DateTime[] temp)
        {
            var formats = new[] { "dd.MM.yyyy", "dd'/'MM'/'yyyy", "yyyy-MM-dd" };
            for (int i = 0; i < args.Length; i++)
            {
                if (!DateTime.TryParseExact(args[i], formats, null, DateTimeStyles.None, out temp[i]))
                {
                    Console.WriteLine("Unable to parse {0}", args[i]);
                    System.Environment.Exit(0);
                }
            }
        }
        public static string WriteDates(string[] args, DateTime[] temp)
        {
            if (args[0].Contains(".") && args[1].Contains("."))
            {
                return temp[0].ToString("dd") + " - " + temp[1].ToString("dd.MM.yyyy");
            }
            else if (args[0].Contains("/") && args[1].Contains("/"))
            {
                return temp[0].ToString("dd'/'MM") + " - " + temp[1].ToString("dd'/'MM'/'yyyy");
            }
            else if (args[0].Contains("-") && args[1].Contains("-"))
            {
                return temp[0].ToString("yyyy-MM-dd") + " - " + temp[1].ToString("yyyy-MM-dd");
            }
            else
            {
                return "Wrong Date Types";
            }
        }
    }
}