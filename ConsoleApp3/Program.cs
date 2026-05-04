using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] f = new int[7, 7];

            Random r = new Random();

            for (int i = 0; i < f.GetLength(0); i++)
            {
                for (int j = 0; j < f.GetLength(1); j++)
                {
                    f[i, j] = r.Next(-100, 100);
                    Console.Write($"{f[i,j]}\t");
                }
                Console.WriteLine();
            }

            int[] min = new int[f.GetLength(1)];

            //базовая проверка массива идет так что похожа со знаком Z, но для моей задачи куда лучше сделать вариант типа И из за того что меньший элемент столбца, а не строки

            for (int i = 0; i < f.GetLength(1); i++)
            {
                min[i] = f[0,i];
                for (int j = 0; j < f.GetLength(0); j++)
                {
                    if (f[j, i] < min[i])
                    {
                        min[i] = f[j,i];
                    }
                }
            }
            Console.WriteLine($"минимальный элемент кадого столбца = {string.Join(" ",min)}");
        }
    }
}
