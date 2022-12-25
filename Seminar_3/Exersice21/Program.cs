// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine(" Вводим x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Вводим y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Вводим z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Вводим x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Вводим y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Вводим z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)));