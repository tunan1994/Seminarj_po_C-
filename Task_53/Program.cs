// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.Console.Clear();

int[,] MatrixRnd(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 40);
        }
    }
    return arr;
    }


void SwapFirstOnLastRow(int[,] arr)
{
    int lastString = arr.GetLength(0) - 1;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[0,j];
        arr[0,j] = arr[lastString, j];
        arr[lastString, j] = temp;
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4}|");
            else Console.Write($"{arr[i, j],4}|");
        }
        Console.WriteLine();
    }
}

int[,] matrixRnd = MatrixRnd(7,5);
PrintMatrix(matrixRnd);
Console.WriteLine();
SwapFirstOnLastRow(matrixRnd);
PrintMatrix(matrixRnd);
