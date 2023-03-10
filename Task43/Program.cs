// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double coordinatX = CoordinatX(b1, k1, b2, k2);
double coordinatY = CoordinatY(coordinatX, b1, k1);

Console.Write($"Заданы координаты: b1 - {b1}, k1 - {k1}, b2 - {b2}, k2 - {k2}"); 
Console.WriteLine();
Console.Write($"Прямые пересекаются в точке ({coordinatX}, {coordinatY})");

double CoordinatX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;         
}

double CoordinatY(double coordinatX, double b1, double k1)
{
    double y = k1 * coordinatX + b1;
    return y;
}
