// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// индексы каждого элемента.
//Массив размером 2 x 2 x 2
int[,,] getMatrix(int[] array)
{
    int[,,] mtrx = new int[array[0], array[1], array[2]];

    int nxtEl = 11;
    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            for(int i = 0; i < mtrx.GetLength(2); i++)
            {
                mtrx[idx, jdx, i] += nxtEl;
                nxtEl += 1;
            }
        }
    }
    return mtrx;
}

void printMtrx(int[,,] matrix)
{
    for(int idx = 0; idx < matrix.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < matrix.GetLength(1); jdx++)
        {
            for(int i = 0; i < matrix.GetLength(2); i++)
            {
            Console.Write($"{matrix[idx, jdx, i]}{(i.ToString(), jdx.ToString(), idx.ToString())} ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
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

int nextElArrSize(string massage)
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
            Console.WriteLine("Введена ошибка! Пробуй еще раз!");
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
        string[] usArrayStrSize = {"cnt", "rows", "cols"};
        int[] usArrayIntSize = userArray(usArrayStrSize, nextElArrSize);
        int[,,] matriX = getMatrix(usArrayIntSize);

        Console.Write("\n");
        printMtrx(matriX);
    }    
}
