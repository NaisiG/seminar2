// Задача 45: напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)       
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
        if(i < arr.Length - 1) Console.Write(arr[i] + ",");     
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[]arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

int[] originArray = CreateArrayRndInt(10, -3, 5);
PrintArray(originArray);

int[] copyArray = CopyArray(originArray);
copyArray[0] = 30;
PrintArray(copyArray);
