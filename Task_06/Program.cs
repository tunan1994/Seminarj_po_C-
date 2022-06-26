// Напишите программу, которая на вход принимает число и выдаёт, является ли число
//  чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int oststok = num1 % 2;
if (oststok == 0)
{
    Console.WriteLine($"Число {num1} является четным");
}
if (oststok == 1)
{
    Console.WriteLine($"Число {num1} не является четным");
}