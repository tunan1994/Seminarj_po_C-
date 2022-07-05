// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Некорректный ввод");

string Quarter(int x, int y)
{
    if (x > 0 && y > 0) return "Первая четверть";
    else if (x > 0 && y < 0) return "Вторая четверть";
    else if (x < 0 && y < 0) return "Третья четверть";
    else if (x < 0 && y > 0) return "Четвертая четверть";
    return "Некорректный ввод";
}

string result = Quarter(x,y);
Console.WriteLine(result);
