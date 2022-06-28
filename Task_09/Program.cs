// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 = > {rndNum}");

// int firstDigit = rndNum / 10;
// int secontDigit = rndNum % 10;

// int maxDigit = firstDigit > secontDigit ? firstDigit : secontDigit;
// Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");
// if (secontDigit == firstDigit)
//     Console.WriteLine($"Цифры числа {rndNum} равны");


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secontDigit = num % 10;
    if (firstDigit == secontDigit) return 0;
    return firstDigit > secontDigit ? firstDigit : secontDigit;
}

int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");


// int maxDigit = firstDigit;
// if (secontDigit > maxDigit) maxDigit = secontDigit;
// else if (secontDigit == maxDigit)  maxDigit = 0;

// if(maxDigit > 0) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");
// else Console.WriteLine($"Цифры числа {rndNum} равны");


// if (firstDigit > secontDigit) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {firstDigit}");
// if (firstDigit < secontDigit) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {secontDigit}");
// if (firstDigit == secontDigit) Console.WriteLine($"Цифры числа {rndNum} => равны");