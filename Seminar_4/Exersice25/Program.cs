/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/
int ToDegree(int numberA, int numberB)
// Функция возведения в степень
{
    int result = numberA;
    for (int idx = 1; idx < numberB; idx++)
    {
        result *= numberA;
    }
    return result;
}
// Функция ввода
int ReadInt()
{
    Console.WriteLine("Введите число A:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    return ToDegree(numberA, numberB);
}

int res = ReadInt();
Console.Write(res);