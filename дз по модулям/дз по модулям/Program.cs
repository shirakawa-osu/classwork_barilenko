using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace дз_по_модулям
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк в данном массиве: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во элементов в строке в данном массиве: ");
            int elements = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            int sum = 0;

            double proiz = 1;

            int[,] nums = new int[lines, elements];

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i,j] = r.Next(-100,101);
                    Console.Write($"{nums[i,j]}\t");
                    if (i == j)
                    {
                        sum += nums[i, j];
                    }
                    else if (i + j == nums.GetLength(0) - 1)
                    {
                        proiz *= nums[i,j];
                        
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов главной диагонали: {sum}\nПроизведение элементов побочной диагонали: {proiz}");

            Console.ReadKey();
        }
    }
}
