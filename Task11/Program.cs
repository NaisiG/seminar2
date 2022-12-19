// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int DeliteSecondDigit (int number)

{
    int first = number / 100;
    int end = number % 10;
    int res = first * 10 + end;
    return res;
}
int res = DeliteSecondDigit (number);
Console.WriteLine(res);
