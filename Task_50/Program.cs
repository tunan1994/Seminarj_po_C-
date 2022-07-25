// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет



Console.Clear();
Console.WriteLine("Введите индекс искомой строки");
int index0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс искомого столбца");
int index1 = int.Parse(Console.ReadLine());

int[,] MatrixRnd(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-10, 10);
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
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4}|");
            else Console.Write($"{arr[i, j],4}|");
        }
        Console.WriteLine();
    }
}


void FindElementIJ(int[,] arr, int index0, int index1)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == (index0-1) && j == (index1-1))
            {
                int x = arr[i,j];
                Console.WriteLine($"Элемет стоящиий на позиции [{index0},{index1}] = {x}");
            }
            if (index0 > arr.GetLength(0) || index1 > arr.GetLength(1))
            {
                Console.WriteLine("Такого элемента в массиве нет");    
                break;                                                
            }                                                       
        }
    }
}


int[,] createMatrix = MatrixRnd(7,9);
PrintMatrix(createMatrix);
Console.WriteLine();
FindElementIJ(createMatrix,index0,index1);