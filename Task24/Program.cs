// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 - > 36

Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
// int number1 = int.Parse(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum+= i;
    }
    return sum;
}
