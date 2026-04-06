using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp_gj_vjlekzv
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите три стороны треугольника числа (стороны треугольника):");

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (Exists(a, b, c))
            {
                Console.WriteLine("\nТреугольник с такими сторонами существует.");
                Calculate_triangle (a, b, c);
            }
            else
            {
                Console.WriteLine("\nТреугольник с такими сторонами не существует.");
            }
        }

        // Метод для определения существования треугольника
        static bool Exists(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c &&
                   a + c > b &&
                   b + c > a;
        }

        // Метод для вычисления площади и периметра
        static void Calculate_triangle(double a, double b, double c)
        {
            double perimeter = a + b + c;

            double p = perimeter / 2;

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Периметр треугольника: {Math.Round(perimeter,2)}");
            Console.WriteLine($"Площадь треугольника: {Math.Round(area,2)}");
        }
    }
}
