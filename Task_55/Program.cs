// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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


void SwapMatrix (int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }
        }
    }
        else
        { 
        Console.WriteLine("No no no");
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

int[,] matrixRnd = MatrixRnd(4, 5);
PrintMatrix(matrixRnd);
Console.WriteLine();
SwapMatrix(matrixRnd);
PrintMatrix(matrixRnd);