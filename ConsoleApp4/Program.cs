using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("введите 1 2 или 3");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("введите x");
                int x = int.Parse(Console.ReadLine());
                double k = 0, n = 0, m = 0, y;
                switch (a)
                {
                    case 1: k = 4; m = -14.7; n = -0.6; break;
                    case 2: k = 3; m = 6.5; n = 3.15; break;
                    case 3: k = 5; m = -12; n = 0.45; break;
                }
                if (3 * x > Math.Abs(m + n)) y = Math.Log(Math.Abs(Math.Log(Math.Abs(k * x + m * n))));
                else if (3 * x == Math.Abs(m + n)) y = Math.Sin(k * m * x) + Math.Sqrt(Math.Abs(n * x));
                else y = Math.Exp(Math.Cos(x)) + Math.Exp(m + n);
                Console.WriteLine("y={0:F2}", y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
