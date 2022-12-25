//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Enter First Number");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int Num2 = Convert.ToInt32(Console.ReadLine());
if(Num1 < Num2)
{
    Console.WriteLine($"{Num1} < {Num2}");
}
else if(Num1 > Num2)
{
    Console.WriteLine($"{Num1} > {Num2}");
}
else
{
    Console.WriteLine($"{Num1} = {Num2}");
}