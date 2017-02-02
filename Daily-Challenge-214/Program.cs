using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyChallenge214
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CalcStdDev("5 6 11 13 19 20 25 26 28 37"));
            Console.WriteLine(CalcStdDev("37 81 86 91 97 108 109 112 112 114 115 117 121 123 141"));
            Console.WriteLine(CalcStdDev("266 344 375 399 409 433 436 440 449 476 502 504 530 584 587"));
            Console.WriteLine(CalcStdDev("809 816 833 849 851 961 976 1009 1069 1125 1161 1172 1178 1187 1208 1215 1229 1241 1260 1373"));
            Console.ReadKey();
        }

        static double CalcStdDev(string vals)
        {
            // split values into array
            var temp = vals.Split(' ').ToList();
            var values = new List<int>();
            temp.ForEach(t => values.Add(Convert.ToInt32(t)));

            // calculate the mean of all values
            double total = 0;            
            values.ForEach(v => total += v);
            double mean = total / values.Count;

            // for each value in array, calculate the difference between it and mean, square it
            // and calculate the sum of these values
            double sumDiff = 0;
            values.ForEach(v => sumDiff += Math.Pow(v - mean, 2));

            // divide by number of values (yields variance)
            double variance = sumDiff / values.Count;
            
            // squareroot of variance (yields standard deviation)

            return Math.Round(Math.Sqrt(variance), 4);
        }
    }
}
