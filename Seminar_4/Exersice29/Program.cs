/*
Задача 29:
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
*/
int[] randArr(int[] smArry)
{
    for(int idx = 0; idx < smArry.Length; idx++)
    {
        Console.WriteLine($"Введите {idx + 1} значение: ");
        int nextNum = Convert.ToInt32(Console.ReadLine());
        smArry[idx] = nextNum;
    }
    return smArry;
}

void prntArry(int[] array)
{
    for(int idx = 0; idx < array.Length; idx++)
    {
        Console.Write($"{array[idx]}, ");
    }
}

int[] array_1 = new int[8];

randArr(array_1);
prntArry(array_1);
