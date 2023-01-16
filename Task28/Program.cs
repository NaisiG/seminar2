// Задача 28: Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

// if number >= 0;


int factorialNumbers = FactorialNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {FactorialNumbers(number)}");



int FactorialNumbers(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    { 
        checked
        {
            result *= i;
        }

    }
    return result;
}
