// Задача 31: 
// Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3, 9 -8, 1, 0, -7, 8, -3, -1, 6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)       //Создание массива
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write(arr[i] + ",");     //Введение внаков в массив
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int GetSumPositiveElement(int[] arr)   //Нахождение суммы положительных чисел
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativElement(int[] arr)   //Нахождение суммы отрицательных чисел
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);     //Печать массива, задаем параметры
PrintArray (array);                             //Печать массива

int sumPositive = GetSumPositiveElement(array);
int sumNegativ = GetSumNegativElement(array);

Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativ}");

// int[] GetSumPosetivNegativElement(int[] arr)   //Нахождение суммы положительных и отрицательных чисел
// {
//     int sumNeg = 0;
//     int sumPos = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) sumPos += arr[i];
//         else if(arr[i] < 0) sumNeg += arr[i];
//     }
//     return new int[]{sumPos, sumNeg};
// }
// int sumPosetivNegativ = GetSumPositiveElement(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPosetivNegativ[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPosetivNegativ[1]}");