using System;

namespace MathExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b0: ");
            double b0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите bk: ");
            double bk = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите deltaB: ");
            double deltaB = Convert.ToDouble(Console.ReadLine());

            for (double b = b0; b <= bk; b += deltaB)
            {
                double I = 0.5 * Math.Pow(x, a) + (Math.Cos(Math.Pow(x, n) + b) / (Math.Pow(x, 2) - b * Math.Sqrt(b))) + Math.Tan(Math.Pow(n, 3));
                Console.WriteLine("b = {0}, I = {1}", b, I);
            }
        }
    }
}