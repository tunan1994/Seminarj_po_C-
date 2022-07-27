// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Задайте число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число N");
int n = Convert.ToInt32(Console.ReadLine());



// void NaturalNumbers(int x, int y)
// {
//     if (x < y)
//     {
//         Console.Write($" {x} ");
//         NaturalNumbers(x + 1, y);
//     }
//     if (x > y)
//     {
//         Console.Write($" {x} ");
//         NaturalNumbers(x - 1, y);
//     }

//     if (x == y) Console.Write($" {y} ");
// }

// Console.Write($"Натуральные числа в промежутке от M = {m} до N = {n} ->");
// NaturalNumbers(m, n);





void NaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        if (m == n) return;
        NaturalNumbers(m + 1, n);
    }
    else if (m > n)
    {
        Console.Write($"{m} ");
        if (m == n) return;
        NaturalNumbers(m - 1, n);
    }
}

Console.Write($"Натуральные числа в промежутке от M = {m} до N = {n} ->");
NaturalNumbers(m, n);