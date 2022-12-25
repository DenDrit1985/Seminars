// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine(" Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
for (int idx = 1; idx <= N; idx++)
{
    Console.Write($"{Math.Pow(idx, 3)}, ");
}