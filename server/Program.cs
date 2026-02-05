using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в программу!");
        Console.WriteLine("ФИО: Чайкалак Данара Рустамовна");
        Console.WriteLine("Группа: ИСП-231");
        Console.WriteLine($"Дата и время: {DateTime.Now}");
         while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату");
            Console.WriteLine("4 — Выход");
            Console.Write("Выберите пункт: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("ФИО: Чайкалак Данара Рустамовна");
                    break;
                case "2":
                    Console.WriteLine("Группа: ИСП-231");
                    break;
                case "3":
                    Console.WriteLine($"Дата и время:{DateTime.Now}");
                    break;
                case "4":
                    Console.WriteLine("Выход");
                    return;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }
        }
    }
}