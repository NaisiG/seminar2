// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату X1: ");
int y1 = ReadInt("Введите координату Y1: ");
int z1 = ReadInt("Введите координату Z1: ");
int x2 = ReadInt("Введите координату X2: ");
int y2 = ReadInt("Введите координату Y2: ");
int z2 = ReadInt("Введите координату Z2: ");

double OurDistance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Длинна отрезка {OurDistance}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


