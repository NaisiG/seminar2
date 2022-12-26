// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);

Console.Clear();
 
void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int firstnum = number / 10000;
        int lastnum = number % 10;
        int secondnum = (number % 10000) / 1000;
        int prelastnum = (number % 100) / 10;
 
            if(firstnum == lastnum && secondnum == prelastnum)
            {
               Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
    Console.WriteLine("Некорректное число!");
}
 

CheckPalindromicNumber(number);