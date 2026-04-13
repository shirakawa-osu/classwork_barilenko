using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите вклад: ");
            double contribution = double.Parse(Console.ReadLine());

            Console.Write("введите кол-во месяцев: ");
            int month = int.Parse(Console.ReadLine());

            if (contribution > 0 && month > 0)
            {
                Console.WriteLine($"ваша сумма вклада за 12 месяцев равен: {accrual(contribution, month)}");
            }
            else
            {
                Console.WriteLine("вклад и кол-во месяцев должно быть больше 0");
            }

                Console.ReadKey();
        }
        static double accrual(double contribution,int month)
        {
            for (int i = 0; i < month; i++)
            {
                if (contribution < 100)
                {
                    contribution += (contribution * 0.05);
                }
                else if (contribution >= 100 && contribution <= 200)
                {
                    contribution += (contribution * 0.07);
                }
                else if (contribution > 200)
                {
                    contribution += (contribution * 0.1);
                }
            }
            return contribution;
        }
    }
}