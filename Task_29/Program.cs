// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов, заполненный псевдослучайными числами и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
void Array(int[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        collection[i] = new Random().Next(0, 100);
        i++;
    }
}

void Print(int[] collection)
{
    int i = 0;
    Console.Write("[");
    while (i < collection.Length)
    {
        Console.Write($"{collection[i]} ");
        i++;
    }
    Console.Write("]");
}

Array(array);
Print(array);