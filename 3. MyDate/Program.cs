using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date = new MyDate(day: 28, month: 2, year: -1300084);
            Console.WriteLine("{0}/{1}/{2}",
                date.Day, date.Month, date.Year);
        }
    }
}
