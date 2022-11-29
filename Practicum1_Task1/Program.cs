using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, res;

            Console.WriteLine("Вычисление среднего геометрического модулей двух чисел\n\n");

            while (true)
            {
                try
                {
                    Console.Write("Введите 1-е число: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Введите 2-е число: ");
                    y = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введено некорректное значение!");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Модуль числа {x} равен {Math.Abs(x)}");
            Console.WriteLine($"Модуль числа {y} равен {Math.Abs(y)}");
            Console.WriteLine();

            res = Math.Sqrt(Math.Abs(x) * Math.Abs(y));
            Console.WriteLine($"Среднее геометрическое модулей двух данных чисел равно {Math.Round(res, 2)}.");
        }
    }
}
