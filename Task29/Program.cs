// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// int[] array = new int[8];

int[] array = CreateArray(8);
PrintArray(array);
Console.WriteLine();



int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(size + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
        break;
    }
    
}

