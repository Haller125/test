int day = int.Parse(Console.ReadLine() ?? "0");
string name = day switch
{
    1 => "Понедельник",
    2 => "Вторник",
    3 => "Среда",
    4 => "Четверг",
    5 => "Пятница",
    6 or 7 => "Выходной!",
    _ => "Нет такого дня..."
};
Console.WriteLine(name);
Console.WriteLine("Hello World!");