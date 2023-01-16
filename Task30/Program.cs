// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нолями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();



void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}