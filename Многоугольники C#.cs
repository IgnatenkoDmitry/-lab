using System;

namespace ShapeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество вершин: ");
            int vertices = Convert.ToInt32(Console.ReadLine());

            switch (vertices)
            {
                case 3:
                    Console.WriteLine("Треугольник");
                    break;
                case 4:
                    Console.WriteLine("Прямоугольник, ромб или квадрат");
                    break;
                case 5:
                    Console.WriteLine("Пятиугольник");
                    break;
                case 6:
                    Console.WriteLine("Шестиугольник");
                    break;
                case 7:
                    Console.WriteLine("Семиугольник");
                    break;
                case 8:
                    Console.WriteLine("Восьмиугольник");
                    break;
                default:
                    Console.WriteLine("Фигуры с таким количеством вершин не задана.");
                    break;
            }
        }
    }
}