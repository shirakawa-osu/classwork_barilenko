using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace абоба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 - создание одномерного массива\n2 - сумма либо вычитание двух массивов\n3 - умножение либо деление двух массивов\nВведите номер действия которое хотите выполнить: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    massive mass = new massive();
                    mass._1mass();
                    break;
                case 2:
                    massive sum = new massive();
                    sum.mass_sum();
                    break;
                case 3:
                    massive mul = new massive();
                    mul.mass_mul();
                    break;
            }

            Console.ReadKey();
        }
    }
    //класс по созданию массивов и действиям с ними
    public class massive
    {
        private int[] nums2;
        private int[] nums1;
        //метод для создания одного массива
        public void _1mass()
        {
            Console.Write("Введите кол-во элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());

            nums1 = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                nums1[i] = r.Next(-10, 10);
                Console.Write($"{nums1[i]} ");
            }
            Console.WriteLine();
        }
        //метод для сложения и вычитания массивов
        public void mass_sum()
        {
            Console.Write("Введите кол-во элементов в обоих массивах: ");
            int n = int.Parse(Console.ReadLine());

            nums1 = new int[n];
            nums2 = new int[n];
            Random r = new Random();
            int[] sum = new int[n];

            Console.WriteLine("Первый массив: ");
            for (int i = 0; i < n; i++)
            {
                nums1[i] = r.Next(-10, 10);
                Console.Write($"{nums1[i]} ");
            }
            Console.WriteLine("\nВторой массив: ");
            for (int i = 0; i < n; i++)
            {
                nums2[i] = r.Next(-10, 10);
                Console.Write($"{nums2[i]} ");
            }

            Console.Write("\n1 - сложение массивов\n2 - вычитание массивов\nВыберите из списка: ");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Ответ: ");
                    for (int i = 0; i < n; i++)
                    {
                        sum[i] = nums1[i] + nums2[i];
                        Console.Write($"{sum[i]} ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Ответ: ");
                    for (int i = 0; i < n; i++)
                    {
                        sum[i] = nums1[i] - nums2[i];
                        Console.Write($"{sum[i]} ");
                    }
                    break;
                default: Console.WriteLine("Ошибка: такого действия нет в списке");
                    break;
            }
        }
        //метод для операции умножения и деления всех элементов на определенное число
        public void mass_mul()
        {
            Console.Write("Введите кол-во элементов в массивe: ");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();

            nums1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums1[i] = r.Next(-10, 10);
                Console.Write($"{nums1[i]} ");
            }

            double[] nums = Array.ConvertAll(nums1, x => (double)x);

            Console.WriteLine("\n1 - умножение массива на определенное число\n2 - деление массива на определенное число\nВыберите действие из списка: ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.Write("Число для умножения: ");
                    double mul = double.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        nums[i] *= mul;
                        Console.Write($"{nums[i]} ");
                    }
                    break;
                case 2:
                    Console.Write("Число для деления: ");
                    double seg = double.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        nums[i] /= seg;
                        Console.Write($"{nums[i]} ");
                    }
                    break;
                default: Console.WriteLine("Ошибка: такого действия нет в списке");
                    break;
            }
        }
    }
}
