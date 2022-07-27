// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Clear();
Console.WriteLine("Задайте число A");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число B");
int m = Convert.ToInt32(Console.ReadLine());

void PowerNumber(int argN, int argPower, int argMemory)
{

    if (argPower > 1)
    {
        argN *= argMemory;
        PowerNumber(argN, argPower - 1, argMemory);
        return;
    }
    else
    {
        Console.Write($"{argN} ");
    }

}
PowerNumber(n, m, n);
