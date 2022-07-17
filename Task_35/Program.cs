// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
void Array(int[] massivRND)
{
    for (int i = 0; i < massivRND.Length; i++)
    {
        massivRND[i] = new Random().Next(0, 1000);
    }
}

int HowManyNumb (int[] arr)
{
    int numb = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            numb = numb + 1;
        }
    }
    return numb;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i==0) Console.Write("Массив [");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
        
    }
}

Array(array);
Print(array);
Console.WriteLine();
int howManyNumb = HowManyNumb(array);
Console.WriteLine($"Количество чисел на отрезке [10,99]  = {howManyNumb}");