// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замение на соответствующие отрицательные,
// и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
        if(i < arr.Length - 1) Console.Write(arr[i] + ", ");     //Введение внаков в массив
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

void Inversion(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = CreateArrayRndInt(12, -9, 9);     //Печать массива, задаем параметры
PrintArray (array);                             //Печать массива
Inversion(array);
PrintArray (array);
