int day = int.Parse(Console.ReadLine() ?? "0");
string name = day switch
{
    1 => "Пн",
    2 => "Вт",
    3 => "Ср",
    4 => "Чт",
    5 => "Пт",
    6 or 7 => "Выходной!",
    _ => "Нет такого дня..."
};
Console.WriteLine(name);