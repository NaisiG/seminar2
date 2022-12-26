// 22. Напишите программу, 
// которая принимает вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    TableSquare(number);
}
else System.Console.WriteLine("Число не корректно");

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}\t" + Math.Pow(count, 2));
        count++;
    }
}