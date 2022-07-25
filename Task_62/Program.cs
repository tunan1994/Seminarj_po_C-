// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] CreateSpiralMatrix(int n,int m)
{
    int[,] arr = new int[n,m];
    int num = 1;
    for (int k = 0; k < n; k++)
    {
        for (int j = 0 + k; j < n - k; j++)
        {
            arr[0 + k, j] = num;
            num++;
        }
        num--;
        for (int i = 0 + k; i < m - k; i++)
        {
            arr[i, n - 1 - k] = num;
            num++;
        }
        num--;
        for (int j = n - 1 - k; j >= 0 + k; j--)
        {
            arr[m - 1 - k, j] = num;
            num++;
        }
        num--;
        for (int i = m - 1 - k; i >= 1 + k; i--)
        {
            arr[i, 0 + k] = num;
            num++;
        }
    }
    num--;
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateSpiralMatrix(5,5);
PrintMatrix(arrayResult);