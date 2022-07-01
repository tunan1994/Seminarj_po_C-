// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0 && num1 < 8)
{
    if (num1 == 6 | num1 == 7) Console.WriteLine("Да"); 
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Некорректный ввод");
