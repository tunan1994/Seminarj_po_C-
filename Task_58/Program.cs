// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 7);
        }
    }
    return arr;
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

int[,] MyltiplicationMatrix(int[,] arr1, int[,] arr2)
{
    int[,] resultMatrix1 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(0) == arr2.GetLength(1))
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    resultMatrix1[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
    return resultMatrix1;
}

int[,] arr1 = CreateMatrixRndInt(2, 2);
Console.WriteLine("Матрица 1:");
PrintMatrix(arr1);
Console.WriteLine();
int[,] arr2 = CreateMatrixRndInt(2,2);
Console.WriteLine("Матрица 2:");
PrintMatrix(arr2);
Console.WriteLine();
int[,] resultMatrix = MyltiplicationMatrix(arr1, arr2);
Console.WriteLine("Произведение матриц:");
PrintMatrix(resultMatrix);