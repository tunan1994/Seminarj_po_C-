// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());
int factorial = 1;   // значение факториала

for (int i = 2; i <= num; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
{
     factorial = factorial * i;
}

Console.WriteLine($"Факториал числа {num} = {factorial}");