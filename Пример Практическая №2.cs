using System;

namespace MathExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите β: ");
            double beta = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите α: ");
            double alpha = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите m: ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            m = (Math.Pow(alpha, 2) + beta) / (Math.Pow(beta, 2) - alpha);

            double x;
            if (m > n)
                x = m;
            else if (n < m)
                x = n;
            else
                x = n * Math.Cos(n);

            double y = (Math.Pow(x, 2) + beta - Math.Cos(beta)) / Math.Sqrt(Math.Pow(beta, 2) + alpha);
            Console.WriteLine("y = {0}", y);

            Console.Write("Введите R: ");
            double R = Convert.ToDouble(Console.ReadLine());

            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= R)
                Console.WriteLine("Точка ({0}, {1}) лежит внутри круга с радиусом {2}.", x, y, R);
            else
                Console.WriteLine("Точка ({0}, {1}) лежит вне круга с радиусом {2}.", x, y, R);
        }
    }
}
