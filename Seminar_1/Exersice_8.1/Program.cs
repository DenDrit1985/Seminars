// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if(N>0)
{
    int index = 1;
    while (index < N+1)
    {
        if(index % 2==0)
        {
            Console.WriteLine(index);
        }
        index ++;
    }
}


