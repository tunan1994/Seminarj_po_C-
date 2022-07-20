// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

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

double[] MeanOfColumns(int[,] arr)
{
    double[] average = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        double register = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
            register = register + 1;
        }
        average[j] = (sum / register);
    }
    return average;
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


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("Среднее арифметическое каждого столбца: [");
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i] + "]");
    }
}


int[,] matrixRnd = MatrixRnd(5,5);
PrintMatrix(matrixRnd);
Console.WriteLine();
double[] meanOfColumns = MeanOfColumns(matrixRnd);
PrintArray(meanOfColumns);