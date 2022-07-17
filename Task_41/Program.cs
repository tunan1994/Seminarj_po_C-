// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Clear();
Console.WriteLine("Сколько чисел нужно поситать: ");
int m = int.Parse(Console.ReadLine());

int[] Chisla(int m)
{
    int[] massiv = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите вещественное число {i + 1}:");
        massiv[i] = int.Parse(Console.ReadLine());
    }
    return massiv;
}

void Print(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < massiv.Length - 1) Console.Write(massiv[i] + ";");
        else Console.Write(massiv[i] + "]");
    }
}

int PolozhitChisla(int[] massiv)
{
    int x = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > 0) x++;
    }
    return x;
}

int[] chisla = Chisla(m);
Print(chisla);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел = {PolozhitChisla(chisla)}");