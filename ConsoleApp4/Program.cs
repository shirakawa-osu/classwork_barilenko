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
            Console.Write("введите вклад: ");
            double contribution = double.Parse(Console.ReadLine());

            if (contribution <= 0)
            {
                Console.WriteLine("вклад должен быть больше 0");
            }
            else
            {
                Console.WriteLine($"ваша сумма вклада за 12 месяцев равен: {accrual(contribution)}");
            }

            Console.ReadKey();
        }
        static double accrual(double contribution)
        {
            for (int i = 0; i < 12; i++)
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
