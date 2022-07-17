// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = new int[9];
void Array(int[] massivRND)
{
    for (int i = 0; i < massivRND.Length; i++)
    {
        massivRND[i] = new Random().Next(0, 10);
    }
}

int[] Proizvedenie(int[] array)
{
    int j = 0;
    if (array.Length % 2 == 0) j = array.Length / 2;
    else j = array.Length / 2 + 1;
    int[] newArr = new int[j];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 > 0) newArr[j - 1] = array[j - 1];
    return newArr;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");

    }
}


Array(array);
Print(array);
Console.WriteLine();
int[] proizvedenie = Proizvedenie(array);
Print(proizvedenie);