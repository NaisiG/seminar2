// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CrateArrayRndInt(int nummber)
{
    int[] arr = new int[nummber];
    Random rnd  = new Random();
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = rnd.Next(-20, 100);
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

int NechetSumArr(int[] array)
{
    int nechetSum = 0;    
    for (int a = 1; a < array.Length; a ++)
    {
        if (a % 2 != 0) 
        nechetSum += array[a];        
    }
    return nechetSum;
}

int[] array = CrateArrayRndInt(5);
PrintArray(array);
int nechetSum = NechetSumArr(array);
Console.WriteLine(nechetSum);