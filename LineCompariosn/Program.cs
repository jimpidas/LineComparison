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
            Console.WriteLine("The length of the line is : ");
            Console.WriteLine(Math.Round(length(5, 6, 7, 3) * 100000.0) / 100000.0);



        }
    }
}
