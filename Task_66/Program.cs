// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Задайте число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число N");
int n = Convert.ToInt32(Console.ReadLine());

int SummNumbers(int x, int y)
{
    if (x == y) return x;
    else if (x < y) return x + SummNumbers(x + 1, y);
    else return x + SummNumbers(x - 1, y);
}
int number = SummNumbers(m, n);
Console.WriteLine(number);