//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ankF(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return ankF(n - 1, 1);
    if (n > 0 && m > 0) return ankF(n - 1, ankF(n, m - 1));
    return ankF(n, m);
}

int[] userArray(string[] array, Func<string, int> f)
{
    int[] array_01 = new int[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = f($"Enter {array[idx]}: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}

int nextEl(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false || num < 0)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if(resVal == false || num < 0)
        {
            Console.WriteLine("Введена ошибка! Пробуй еще!");
        }
    }
    return num;
}

while(true)
{
    Console.Write("\n");
    Console.WriteLine("\nEnter 's' to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Пока!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] usArrayStr = {"m", "n"};
        int[] usArrayInt = userArray(usArrayStr, nextEl);
        int result = ankF(usArrayInt[0], usArrayInt[1]);
        Console.WriteLine($"\nResult = {result}");
    }    
}
