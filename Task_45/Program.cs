// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] CoppyArray(int[] arr)
{
    int size = arr.Length;
    int[] newArr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i];
        // if (i==0) newArr[i] = 55;
    }
    return newArr;
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

int[] array = CreateArrayRndInt(8, 1, 200);
Print(array);
Console.WriteLine();
int[] newArray = CoppyArray(array);
Print(newArray);