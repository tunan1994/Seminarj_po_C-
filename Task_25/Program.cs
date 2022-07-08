// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B: ");
int b = int.Parse(Console.ReadLine());

int Stepen(int A, int B)
{
    int x = 1;
    for (int i = 1; i <= B; i++)
    {
        x = x * A;
    }
    return x;
}
int ex = Stepen(a, b);
Console.WriteLine($"{a} в степени {b} = {ex}");