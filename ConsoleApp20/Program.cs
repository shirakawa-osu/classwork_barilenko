using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер действия которое хотите выполнить\n1: сумма двух массивов(если они одинакового размера)");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    massive sum = new massive();
                    sum.mass_sum();
                    break;
            }

            Console.ReadKey();
        }
    }
    //класс по созданию массивов
    public class massive
    {
        private int _count;
        private int _element;
        //метод для создания массивов
        public void _1dmass()
        {
            Console.Write("Введите кол-во элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());

            this._count = n;

            int[] nums = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                nums[i] = r.Next(-10,10);
                Console.Write($"{nums[i]}\t");
                this._element = nums[i];
            }
            Console.WriteLine();
        }
        //метод для сложения массивов
        public void mass_sum()
        {
            massive mass1 = new massive();
            mass1._1dmass();

            massive mass2 = new massive();
            mass2._1dmass();

            int[] sum_mass = new int[mass1._count];

            if (mass1._count == mass2._count)
            {
                Console.WriteLine("Операция поэлементного сложения массива: ");
                for (int i = 0; i < mass1._count; i++)
                {
                    sum_mass[i] = mass1._element + mass2._element;
                    Console.Write($"{sum_mass[i]}\t");
                }
            }
            else
            {
                Console.WriteLine("Массивы разных размеров, сложение их невозможно");
            }
        }
    }
}
