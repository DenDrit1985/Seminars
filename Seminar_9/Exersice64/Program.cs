// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

void PrintReqursive(int number, int currentnumber = 1)
        {
            if(number == currentnumber) return;
            Console.Write(number + ", ");
            PrintReqursive(number - 1, currentnumber);
        }

int nextEl(string massage)
{
    bool resVal = false;
    int num = 0;
    while(resVal == false || num < 0)
    {
        resVal = Int32.TryParse(massage, out num);
        if(resVal == false || num < 0)
        {
            Console.WriteLine("Введена ошибка! Пробуй еше раз!");
            break;
        }
    }
    return num;
}

while(true)
{
    Console.WriteLine("\nEnter  positive number to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Пока!");
        break;
    }
    else
    {
        int numb = nextEl(usrQuest);
        PrintReqursive(numb);
        Console.Write(1);
    }
}
