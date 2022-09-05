using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClock clock = new MyClock(25, 38, 42);
            Console.WriteLine("{0}:{1}:{2}", clock.Hours, clock.Minutes, clock.Seconds);
        }
    }
}
