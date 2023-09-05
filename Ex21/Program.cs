//Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 3D
//пространстве.

double Distance (int a1, int a2, int a3, int b1, int b2, int b3)
{
    int r1 = a1 - b1;
    int r2 = a2 - b2;
    int r3 = a3 - b3;
double distance = Math.Sqrt (r1 * r1 + r2 * r2 + r3 * r3);
return distance;
}

Console.WriteLine("Введите координты точки А");
Console.Write("Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("У: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
Console.Write("Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("У: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Х: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, z1, x2, y2, z2);  
 double dRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно -> {dRound}");
