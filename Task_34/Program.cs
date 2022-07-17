// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = new int[12];
void Array(int[] massivRND)
{
    for (int i = 0; i < massivRND.Length; i++)
    {
        massivRND[i] = new Random().Next(100, 1000);
    }
}


int HowManyChet(int[] arr)
{
    int chetn = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) chetn = chetn+1;
    }
    return chetn;
}

void Print(int[] massivRND)
{
    int i = 0;
    Console.Write("[");
    while (i < massivRND.Length)
    {
        Console.Write($"{massivRND[i]} ");
        i++;
    }
    Console.Write("]");
}

Array(array);
Print(array);
Console.WriteLine();
int howManyChet = HowManyChet(array);
Console.WriteLine($"Количество четных чисел = {howManyChet}");