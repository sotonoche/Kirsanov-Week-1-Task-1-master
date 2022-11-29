using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введено некорректное значение!");
                }

            }
                string res = Math.Abs(n) % 10 == 7 ? "Оканчивается на семь" : "Не оканчивается на семь";
                Console.WriteLine(res);
        }
    }
}
