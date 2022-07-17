// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = new int[12];
void Array(int[] massivRND)
{
    for (int i = 0; i < massivRND.Length; i++)
    {
        massivRND[i] = new Random().Next(0, 1000);
    }
}

int SumNeChetnPosition (int[] array)
{
    int num = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        num = num + array[i];
    }
    return num;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.WriteLine(array[i] + "]");

    }
}

Array(array);
Print(array);
Console.WriteLine();
int sumNeChetnPosition = SumNeChetnPosition(array);
Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях = {sumNeChetnPosition}");
