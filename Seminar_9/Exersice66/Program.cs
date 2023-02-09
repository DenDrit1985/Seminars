// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numSum(int M, int N, int sum = 0)
{
    if(M > N) return sum;
    sum += M;
    return numSum(M + 1, N, sum);    
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
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if(resVal == false)
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
        string[] usArrayStr = {"M", "N"};
        int[] usArrayInt = userArray(usArrayStr, nextEl);
        if(usArrayInt[0] <= usArrayInt[1])
        {
            int resSum = numSum(usArrayInt[0], usArrayInt[1]);
            Console.WriteLine($"\nResult sum = {resSum}");
        } 
        else
        {
            int resSum = numSum(usArrayInt[1], usArrayInt[0]);
            Console.WriteLine($"\nResult sum = {resSum}");
        }
    }    
}
