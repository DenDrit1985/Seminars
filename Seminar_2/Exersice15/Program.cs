//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.;
Console.Write(" Введите значение дня недели ");
int WeekDay = Convert.ToInt32(Console.ReadLine());
if (WeekDay < 1 || WeekDay > 7 )
{
    Console.Write(" Такого дня недели не существует ");
}
else{
    if (WeekDay /6 == 1)
    {
        Console.Write(" Да выходной ");
    }
    else
    {
        Console.Write(" Нет рабочий ");
    }
}