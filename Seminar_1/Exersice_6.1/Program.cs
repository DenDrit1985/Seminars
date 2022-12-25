//Напишите программу, которая на вход принимает число и выдаёт, что является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine(" ведите число, а программа определит чётное ли оно ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % 2 == 0)
    Console.WriteLine("Это чётное число");
else
    Console.WriteLine("Это Нечётное число");
