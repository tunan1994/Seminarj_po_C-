// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] array = new double[12];
void Array(double[] massivRND)
{
    for (int i = 0; i < massivRND.Length; i++)
    {
        massivRND[i] = new Random().Next(0, 1001)/10.0;
    }
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.WriteLine(array[i] + "]");

    }
}

double Razniza(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

Array(array);
Print(array);
double razniza = Razniza(array);
Console.WriteLine($"Разница между max и min  = {razniza}");