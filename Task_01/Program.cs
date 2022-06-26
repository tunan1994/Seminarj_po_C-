// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2*num2==num1)
{
    Console.WriteLine($"Число {num1} являеется квадратом числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} не являеется квадратом числа {num2}");
}
