// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет!!!!!!!!");
Console.WriteLine("Богданов Иван Антонович");
Console.WriteLine("ИСП-233");
Console.WriteLine("19.01.2026");
Console.WriteLine("16:23");


Console.WriteLine("Меню: ");
Console.WriteLine("1 — Показать ФИО");
Console.WriteLine("2 — Показать группу");
Console.WriteLine("3 — Показать дату");
Console.WriteLine("4 — Выход");

Console.Write("Выберите пункт меню: ");
string input = Console.ReadLine();

switch (input)
{
    case "1":
        Console.WriteLine("Ваше ФИО: Боогданов Иван Антонович");
        break;
    case "2":
        Console.WriteLine("Ваша группа: ИСП-233");
        break;
    case "3":
        Console.WriteLine($"Текущая дата: 19.01.2026");
        break;
    case "4":
        Console.WriteLine("Выход из программы...");
        break;
    default:
        Console.WriteLine("Неверный ввод. Пожалуйста, выберите пункт от 1 до 4.");
        break;
}