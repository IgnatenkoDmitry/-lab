using System;

namespace RoundingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double positiveValue = 4.5;
            double negativeValue = -4.5;

            Console.WriteLine("Positive value: " + positiveValue);
            Console.WriteLine("Negative value: " + negativeValue);
            
            Console.WriteLine("\nMath.Ceiling:");
            Console.WriteLine("Positive value: " + Math.Ceiling(positiveValue));
            Console.WriteLine("Negative value: " + Math.Ceiling(negativeValue));
            
            Console.WriteLine("\nConvert.ToInt32:");
            Console.WriteLine("Positive value: " + Convert.ToInt32(positiveValue));
            Console.WriteLine("Negative value: " + Convert.ToInt32(negativeValue));

            Console.WriteLine("\nMath.Round with MidpointRounding.ToEven (default):");
            Console.WriteLine("Positive value: " + Math.Round(positiveValue));
            Console.WriteLine("Negative value: " + Math.Round(negativeValue));

            Console.WriteLine("\nMath.Round with MidpointRounding.AwayFromZero:");
            Console.WriteLine("Positive value: " + Math.Round(positiveValue, MidpointRounding.AwayFromZero));
            Console.WriteLine("Negative value: " + Math.Round(negativeValue, MidpointRounding.AwayFromZero));

            Console.WriteLine("\nMath.Floor:");
            Console.WriteLine("Positive value: " + Math.Floor(positiveValue));
            Console.WriteLine("Negative value: " + Math.Floor(negativeValue));
        }
    }
}