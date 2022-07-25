// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка.

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0,25);
        }
    }
    return arr;
}

int[] SumString(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ+= arr[i, j];
        }
        result[i] = summ;
    }
    return result;
}

int MinLine(int[] array)
{
    int minString = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minString])
        {
            minString = i;
        }
    }
    return minString + 1;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],2} | ");
            else Console.Write($"{arr[i, j],2} |");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Сумма чисел каждой строки: ");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + ".");
    }
    Console.WriteLine("\b");
}


int[,] matrixResult = CreateMatrixRndInt(4, 5);
PrintMatrix(matrixResult);
Console.WriteLine();
int[] sumString = SumString(matrixResult);
PrintArray(sumString);
int minLine = MinLine(sumString);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minLine}");