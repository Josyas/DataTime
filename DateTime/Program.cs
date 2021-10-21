using System;
using System.Globalization;

namespace tempo {
    class Program {
        static void Main(string[] args) {


            DateTime d0 = DateTime.Now;
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Today;
            DateTime d3 = DateTime.UtcNow;

            Console.WriteLine("Now: " + d0);
            Console.WriteLine("Ticks: " + d1.Ticks);
            Console.WriteLine("Today: " + d2);
            Console.WriteLine("UtcNow: " + d3);

            Console.WriteLine("-------------------------------");

            DateTime d4 = DateTime.Parse("21-10-2021 05:08:59");
            DateTime d5 = DateTime.Parse("21-10-2021");

            Console.WriteLine(d4);
            Console.WriteLine(d5);

            Console.WriteLine("-------------------------------");

            DateTime d6 = DateTime.ParseExact("21-10-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime d7 = DateTime.ParseExact("21-10-2021 05:15:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d6);
            Console.WriteLine(d7);
        }
    }
}
