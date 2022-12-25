// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write(" Введите 5-ти значное число ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number.ToString().Length == 5)
{
    int tmp = 0;
    int num = Number;
    while (tmp.ToString().Length < 5) 
    {
        tmp *= 10;
        tmp += num % 10;
        num /= 10;
    }
     if (Number == tmp)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
}            