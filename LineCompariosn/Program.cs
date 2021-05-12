using System;

namespace LineComparisonProblem
{
    class Program
    {
        static double length(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
        }
        static void Main(string[] args)
        {
            double line1, line2;

            line1 = (Math.Round(length(5, 6, 7, 3) * 100000.0) / 100000.0);
            line2 = (Math.Round(length(3, 7, 8, 4) * 100000.0) / 100000.0);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            if (line1 == line2)
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are  not equal");
            if (line1 > line2)
                Console.WriteLine("Line 1 is greater : " + line1);
            else if (line2 > line1)
                Console.WriteLine("Line 2 is greater : " + line2);
        }

    }
}
