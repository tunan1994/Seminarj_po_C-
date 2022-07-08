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