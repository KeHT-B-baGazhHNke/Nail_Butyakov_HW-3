using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    enum week
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание 1 определить является ли последовательность возрастающей");
                Random rnd = new Random();
                bool vozr = false;
                int[] dgts = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    dgts[i] = rnd.Next();
                }
                int res = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i > 0 && dgts[i] <= dgts[i - 1])
                    {
                        res = i + 1;
                        vozr = true;
                        break;
                    }
                }
                Console.WriteLine($"Последовательность: {string.Join(" ", dgts)}");
                Console.WriteLine(vozr ? $"Последовательность не упорядочена по возрастанию, порядковый номер числа которое нарушает последовательность: {res}" : "Последовательность упорядочена по возрастанию");
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\nЗадание 2 достоинство карты по номеру");
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(6, "Шестерка");
                dict.Add(7, "Семерка");
                dict.Add(8, "Восьмерка");
                dict.Add(9, "Девятка");
                dict.Add(10, "Десятка");
                dict.Add(11, "Валет");
                dict.Add(12, "Королева");
                dict.Add(13, "Король");
                dict.Add(14, "Туз");
                bool bl = true;
                var crd = 0;
                Console.Write("Введите номер карты (от 6 до 14): ");
                try
                {
                    while (bl)
                    {
                        crd = int.Parse(Console.ReadLine());
                        if (crd > 14 || crd < 6)
                        {
                            Console.Write("Введите число от 6 до 14!: ");
                        }
                        else
                        {
                            Console.WriteLine($"Достоинство карты: {dict[crd]}");
                            break;
                        }
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ошибка, вы ввели не число!");
                }
                finally
                {
                    Console.WriteLine("Спасибо за попытку!\n\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
            {
                Console.WriteLine("\nЗадание 3, что пить?\nКто вы по жизни?");
                string who = Console.ReadLine();
                switch (who.ToLower())
                {
                    case "jabroni": Console.WriteLine("Patron Tequila"); break;
                    case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                    case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                    case "bike gang member": Console.WriteLine("Moonshine"); break;
                    case "politician": Console.WriteLine("Your tax dollars"); break;
                    case "rapper": Console.WriteLine("Cristal"); break;
                    default: Console.WriteLine("Beer"); break;
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\nЗадание 4 день недели по номеру\nВведите номер дня недели");
                int day;
                bool res = int.TryParse(Console.ReadLine(), out day);
                if (res && day > 0 && day < 8)
                {
                    Console.WriteLine(Enum.GetName(typeof(week), day - 1));
                }
                else
                {
                    Console.WriteLine("Ошибка, неверные входные данные");
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\nЗадание 5 куклы в сумке");
                int c = 0;
                string[] dolls = new string[10] { "Barbie doll", "Voodo doll", "Hello Kitty", "Bratz doll", "Barbie doll", "Chucki doll", "inflatable doll", "Hello Kitty", "Barbie doll", "Billie doll" };

                foreach (string doll in dolls)
                {
                    if (doll == "Barbie doll" || doll == "Hello Kitty")
                    {
                        c++;
                    }
                }
                Console.WriteLine($"{c} кукол в сумке");
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}
