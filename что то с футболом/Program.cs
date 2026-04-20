using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace что_то_с_футболом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] goalsScored = new int[20];
            int[] goalsConceded = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                goalsScored[i] = rnd.Next(0, 10);
                goalsConceded[i] = rnd.Next(0, 10);
            }

            // Вывод исходных данных
            Console.WriteLine("Забитые мячи:   " + string.Join(" ", goalsScored));
            Console.WriteLine("Пропущенные мячи:" + string.Join(" ", goalsConceded));
            Console.WriteLine();

            // a) Словесный результат для каждой игры
            Results(goalsScored, goalsConceded);

            // г) Количество выигрышей, ничьих и проигрышей
            Count(goalsScored, goalsConceded, out int wins, out int draws, out int losses);
            Console.WriteLine($"г) Выигрышей: {wins}, Ничьих: {draws}, Проигрышей: {losses}");

            // д) Игры с разностью >= 3
            int diff = Count_with_diff(goalsScored, goalsConceded);
            Console.WriteLine($"д) Игр с разностью забитых и пропущенных >= 3: {diff}");

            // е) Общее число очков
            int totalPoints = Calculate_points(goalsScored, goalsConceded);
            Console.WriteLine($"е) Общее число очков: {totalPoints}");
        }

        // a) Для каждой игры выводим результат
        static void Results(int[] scored, int[] conceded)
        {
            Console.WriteLine("а) Результаты игр:");
            for (int i = 0; i < scored.Length; i++)
            {
                string result;
                if (scored[i] > conceded[i])
                {
                    result = "выигрыш";
                }
                else if (scored[i] == conceded[i])
                {
                    result = "ничья";
                }
                else
                {
                    result = "проигрыш";
                }

                Console.WriteLine($"Игра {i + 1,2}: {scored[i]}-{conceded[i]} — {result}");
            }
        }
        // г) Количество выигрышей, ничьих и проигрышей
        static void Count(int[] scored, int[] conceded, out int wins, out int draws, out int losses)
        {
            wins = 0;
            draws = 0;
            losses = 0;
            for (int i = 0; i < scored.Length; i++)
            {
                if (scored[i] > conceded[i])
                    wins++;
                else if (scored[i] == conceded[i])
                    draws++;
                else
                    losses++;
            }
        }

        // д) Количество игр, где разность забитых и пропущенных более либо равная трем
        static int Count_with_diff(int[] scored, int[] conceded)
        {
            int count = 0;
            for (int i = 0; i < scored.Length; i++)
            {
                int difference = scored[i] - conceded[i];
                if (difference >= 3)
                    count++;
            }
            return count;
        }

        // е) Общее число очков
        static int Calculate_points(int[] scored, int[] conceded)
        {
            int points = 0;
            for (int i = 0; i < scored.Length; i++)
            {
                if (scored[i] > conceded[i])
                    points += 3;
                else if (scored[i] == conceded[i])
                    points += 1;
            }
            return points;
        }
    }
}
