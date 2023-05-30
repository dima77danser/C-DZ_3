// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("ВВедите число");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int x3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int y3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число");
int z3 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x3-x2-x1),2) + Math.Pow((y3-y2-y1),2) + Math.Pow((z3-z2-z1),2));
Console.WriteLine(d);
