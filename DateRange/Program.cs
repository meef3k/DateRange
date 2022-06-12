using System;

namespace DateRange
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] temp = new DateTime[2];
            Date.GenerateDate(args, temp);
            Console.WriteLine(Date.WriteDates(args, temp));
        }
    }
}