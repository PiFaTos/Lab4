using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    internal class Program
    {
        static void PrintMenu(int x, int y, string[] menu, int active)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < menu.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(menu[i]);
            }

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x, y + active);
            Console.Write(menu[active]);
        }

        static int SelectMenuItem(int x, int y, string[] menu)
        {
            Console.CursorVisible = false;
            bool isWorking = true;
            int active = 0;
            while (isWorking)
            {
                PrintMenu(x, y, menu, active);
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.Enter:
                        isWorking = false;
                        break;
                    case ConsoleKey.UpArrow:
                        // защита от выхода
                        active--;
                        break;
                    case ConsoleKey.DownArrow:
                        // защита от выхода
                        active++;
                        break;
                }
            }

            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            return active;
        }

        static void DrawLine()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(5, 2 + i);
                Console.Write("│");
            }
        }
        static int DisplaySelectedItem(int article, pistols[] pistols, rifles[] rifles, knives[] knives)
        {
            foreach (var pistol in pistols)
            {
                if (pistol.Articcle == article)
                {
                    Console.WriteLine($"{pistol.Articcle,-10} {pistol.Name,-15} {pistol.Price,-10}");
                    return pistol.Price;
                }
            }

            foreach (var rifle in rifles)
            {
                if (rifle.Articcle == article)
                {
                    Console.WriteLine($"{rifle.Articcle,-10} {rifle.Name,-15} {rifle.Price,-10}");
                    return rifle.Price;
                }
            }

            foreach (var knife in knives)
            {
                if (knife.Articcle == article)
                {
                    Console.WriteLine($"{knife.Articcle,-10} {knife.Name,-15} {knife.Price,-10}");
                    return knife.Price;
                }
            }

            Console.WriteLine($"Товар с артиклем {article} не найден.");
            return 0;
        }
        static void Main(string[] args)
        {
            List<int> buy = new List<int>();
            pistols[] pistols = {
                new pistols(12345, "Пистолет Макарова", "МП", "ПМ", "9x18 мм", 730, "Черный", 15000, 160, 93, 8),
            // Пистолет Glock 17
                new pistols(67890, "Glock 17", "Glock", "G17", "9x19 мм", 625, "Черный", 40000, 210, 102, 17),
            // Пистолет ТТ (Токарева)
                new pistols(12346, "Пистолет ТТ", "Тульский Завод", "ТТ", "7.62x25 мм", 800, "Черный", 20000, 200, 114, 8),
            // Пистолет FN Five-seveN
                new pistols(11224, "FN Five-seveN", "FN Herstal", "Five-seveN", "5.7x28 мм", 590, "Черный", 60000, 208, 123, 20),
            };
            knives[] knives = {
            // Нож Victorinox Swiss Army
                 new knives(1001, "Victorinox Swiss Army", "Victorinox", "Многофункциональный", 5000, "Пластик"),

            // Нож Ka-Bar Becker BK2
                new knives(1002, "Ka-Bar Becker BK2", "Ka-Bar", "Туристический", 10000, "Нейлон"),

            // Нож SOG Seal Pup
                new knives(1003, "SOG Seal Pup", "SOG", "Тактический", 7000, "Резина"),

            // Нож ESEE Izula
                new knives(1004, "ESEE Izula", "ESEE", "Полевой", 8000, "Паракорд"),
            };
            rifles[] rifles = {
            // Винтовка Remington 700
                 new rifles(2001, "Remington 700", "Remington", "700", "7.62x51 мм", 4200, "Черный", 80000, 1000, 610, 5),

            // Винтовка AR-15
                new rifles(2002, "AR-15", "Colt", "AR-15", "5.56x45 мм", 3200, "Камуфляж", 90000, 1000, 460, 30),

            // Винтовка Mosin-Nagant
                new rifles(2003, "Mosin-Nagant", "Ижевский Завод", "Мосина", "7.62x54 мм", 4000, "Дерево", 25000, 1250, 730, 5),

            // Винтовка Tikka T3x
                new rifles(2004, "Tikka T3x", "Tikka", "T3x", "6.5x55 мм", 3700, "Синий", 95000, 1080, 600, 5)
            };
            string[] cities = { "Челябинск", "Куса", "Чебаркуль", "Миасс", "Карталы" };
            string[] guns = {"Купить Пистолет", "Купить Винтовку", "Купить Нож", "Вывести чек"};
            string[] art = new string[]
        {
            "Вас приветствует магазин оружия                                                                                     ",
            "                                                                                      ",
            "                                                                                      ",
            "         $█     ▄█             ▄██▀▀█L",
            "          ██⌐  ▄█            ╔█▀        ▄█▀▀▀█µ  ▐█▄▀▀▀█▄   ██▀▀▀▀▀  ,█▀▀▀█▄   ▄█▀▀▀██",
            "           ▀█▄█▀             ██        ▐█▄▄▄▄██  ▐█    ██   █▌       ██▄▄▄▄█▌  ▀█▄,,██",
            "            ██▀              ▀█▄       ▐█⌐       ▐█    ██   █▌       ██         ▄█▀▀██",
            "         ╔▄█▀                 ╙▀█▄▄▄▄▌  ▀██▄▄▄█  ▐█▀▄▄█▀    █▌        ▀█▄▄▄▄Γ  ██   ██",
            "                                                 ▐█",
            "                                                 \"▀",
            "                                                                                "
        };

            foreach (string line in art)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("                                             Выберете город доставки:");
            int selectCity = SelectMenuItem(50, 15, cities);
            Console.WriteLine("                                             Выберете действие:");
            int fl = 0;
            do
            {
                int selectGun = SelectMenuItem(50, 15, guns);
                switch (selectGun)
                {
                    case 0:
                        Console.WriteLine($"{"Article",-10} {"Name",-15} {"Brand",-15} {"Model",-15} {"Caliber",-10} {"Weight",-10} {"Color",-10} {"Price",-10} {"Length",-10} {"Barrel length",-10} {"Magazine",-10}");
                        Console.WriteLine(new string('-', 110));
                        foreach (var pistol in pistols)
                        {
                            pistol.Display();
                        }
                        Console.WriteLine("Введите артикль выбранного товара:");
                        buy.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear(); 

                        break;
                    case 1:
                        Console.WriteLine($"{"Article",-10} {"Name",-15} {"Brand",-15} {"Model",-10} {"Caliber",-10} {"Weight",-10} {"Color",-10} {"Price",-10} {"Length",-10} {"Barrel",-10} {"Capacity",-10}");
                        Console.WriteLine(new string('-', 80));
                        foreach (var rifle in rifles)
                        {
                            rifle.Display();
                        }
                        Console.WriteLine("Введите артикль выбранного товара:");
                        buy.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine($"{"Article",-10} {"Name",-15} {"Brand",-15} {"Type",-10} {"Price",-10} {"Handle",-10}");
                        Console.WriteLine(new string('-', 80));
                        foreach (var knife in knives)
                        {
                            knife.Display();
                        }
                        Console.WriteLine("Введите артикль выбранного товара:");
                        buy.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear();
                        break;
                    
                    case 3:
                        Console.Clear();
                        int consoleWidth = Console.WindowWidth; // Ширина консоли
                        string title = "Выбранные товары:";
                        Console.SetCursorPosition((consoleWidth - title.Length) / 2, 1);
                        Console.WriteLine(title);

                        // Заголовки
                        Console.SetCursorPosition((consoleWidth - 25) / 2, 3);
                        Console.WriteLine($"{"Article",-10} {"Name",-15} {"Price",-10}");
                        Console.SetCursorPosition((consoleWidth - 25) / 2, 4);
                        Console.WriteLine(new string('-', 25));

                        int Sum = 0;
                        int lineNumber = 5; // Начальная строка для вывода товаров
                        foreach (var article in buy)
                        {
                            Console.SetCursorPosition((consoleWidth - 25) / 2, lineNumber++);
                            Sum += DisplaySelectedItem(article, pistols, rifles, knives);
                        }
                        // Вывод информации о городе и итоговой суммы
                        Console.SetCursorPosition((consoleWidth - 25) / 2, lineNumber);
                        Console.WriteLine($"Город доставки={cities[selectCity]}");
                        Console.SetCursorPosition((consoleWidth - 25) / 2, lineNumber + 1);
                        Console.WriteLine(new string('-', 25));
                        Console.SetCursorPosition((consoleWidth - 25) / 2, lineNumber + 2);
                        Console.WriteLine($"Итоговая сумма: {Sum,-10}");
                        //Console.SetCursorPosition((consoleWidth - 40) / 2, lineNumber + 4);
                        Console.WriteLine("Введите артикль товара для удаления с помощью клавиш вверх, вниз (или 'exit' для выхода):");

                        string input = Console.ReadLine();
                        if (input.ToLower() != "exit" && int.TryParse(input, out int articleToRemove))
                        {
                            if (buy.Remove(articleToRemove))
                            {
                                Console.Clear();
                                Console.SetCursorPosition((consoleWidth - 25) / 2, lineNumber + 5);
                                Console.WriteLine($"Товар с артиклем {articleToRemove} удален.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.SetCursorPosition((consoleWidth - 25) / 2, lineNumber + 5);
                                Console.WriteLine($"Товар с артиклем {articleToRemove} не найден в чеке.");
                            }
                        }
                        if (input.ToLower() == "exit") fl = 1;
                        break;

                }
            } while (fl == 0);
            
        }
    }

}
