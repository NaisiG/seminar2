// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CrateArrayRndInt(int nummber)
{
    int[] arr = new int[nummber];
    Random rnd  = new Random();
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("] ");
}

int HetSumArr(int[] array)
{
    int hetSum = 0;    
    for (int a = 0; a < array.Length; a ++)
    {
        if ((a & 1) == 0)
        hetSum++;;        
    }
    return hetSum;
}

int[] array = CrateArrayRndInt(5);
PrintArray(array);
int HetSum = HetSumArr(array);
Console.WriteLine(HetSum);