//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координату x первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double distance = Math.Round(Math.Sqrt(A * A + B * B + C * C), 2);
Console.WriteLine($"Расстояние между точками {distance}");