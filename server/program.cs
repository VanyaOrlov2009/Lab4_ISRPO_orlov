Console.WriteLine("Добро пожаловать!");
Console.WriteLine("ФИО: Орлов Иван Леонидович");
Console.WriteLine("Группа: ИСП-241");
Console.WriteLine("Дата: 17.10.2026, 23:46");

bool a = true;
while (a)
{
    Console.WriteLine();
    Console.WriteLine("Меню:");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.Write("Ваш выбор: ");

    string b = Console.ReadLine();

    if (b == "1")
    {
        Console.WriteLine("ФИО: Орлов Иван Леонидович");
    }
    else if (b == "2")
    {
        Console.WriteLine("Группа: ИСП-241");
    }
    else if (b == "3")
    {
        Console.WriteLine("Дата: 17.10.2026, 23:46");
    }
    else if (b == "4")
    {
        Console.WriteLine("Выход...");
        a = false;
    }
    else
    {
        Console.WriteLine("Неверный выбор, попробуйте снова ");
    }
}
