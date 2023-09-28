using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Упражнение 4.1 перевод числа в дату\nВведите номер дня в году, число от 1 до 365: ");
                int day;
                bool res = int.TryParse(Console.ReadLine(), out day);
                if (res)
                {
                    DateTime date = new DateTime(2022, 12, 31);
                    Console.WriteLine($"{day}-му дню в году соответсвует {date.AddDays(day).ToString("M")}");

                }
                else
                {
                    Console.WriteLine("Введены неверные данные");
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nУпражнение 4.2 перевод числа в дату с проверкой входных данных\nВведите номер дня в году, число от 1 до 365: ");
                int day;
                bool res = int.TryParse(Console.ReadLine(), out day);
                if (res && day < 366 && day > 0)
                {
                    DateTime date = new DateTime(2022, 12, 31);
                    Console.WriteLine($"{day}-му дню в году соответсвует {date.AddDays(day).ToString("M")}");

                }
                else
                {
                    Console.WriteLine("Введены неверные данные");
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nДомашнее задание 4.1 перевод числа в дату с учетом високосного года\nВведите номер дня в году, число от 1 до 365: ");
                int day, year;
                bool res = int.TryParse(Console.ReadLine(), out day);
                Console.Write("Введите год: ");
                bool res1 = int.TryParse(Console.ReadLine(), out year);
                if (res && res1)
                {
                    DateTime date = new DateTime((year - 1), 12, 31);
                    Console.WriteLine($"{day}-му дню в году соответсвует {date.AddDays(day).ToString("M")}");

                }
                else
                {
                    Console.WriteLine("Введены неверные данные");
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}
