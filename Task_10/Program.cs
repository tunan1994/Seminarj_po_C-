// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 100 && num1 < 1000)
{
    int del = num1 / 10;
    int res = del % 10;
    Console.WriteLine($"{res}");
}
else Console.WriteLine("Некорректный ввод");