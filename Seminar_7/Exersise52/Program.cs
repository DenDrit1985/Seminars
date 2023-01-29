// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] getRandMatrix(int[] sizeArray, int[] bordArray)
{
    int[,] mtrx = new int[sizeArray[0], sizeArray[1]];

    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            mtrx[idx, jdx] = new Random().Next(bordArray[0], bordArray[1]);
        }
    }
    return mtrx;
}

void printMean(int[,] matrix)
{
    int count = 0;
    var averages = matrix.Cast<int>()
                    .GroupBy(x => count++ / matrix.GetLength(1))
                    .Select(g => g.Average())
                    .ToArray();
    for(int idx = 0; idx < averages.Length; idx++)
    {
        Console.WriteLine($"Average value {idx + 1} row: {averages[idx]}");
    }
}

void printMtrx(int[,] matrix)
{
    for(int idx = 0; idx < matrix.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < matrix.GetLength(1); jdx++)
        {
            Console.Write(matrix[idx, jdx] + " ");
        }
        Console.Write("\n");
    }
}

int[] userArray(string[] array)
{
    int[] array_01 = new int[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = nextElArrSize($"Enter {array[idx]}: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}

int nextElArrSize(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = inpValidSize(elem);
        if(resVal == true)
        {
            num = Int32.Parse(elem);
        }
        else
        {
            Console.WriteLine("Ввод с ошибкой. Пробовать еще раз");
            continue;
        }      
    }
    return num;
}

bool inpValidSize(string num)
{
    bool res_val = Int32.TryParse(num, out int res_num);
    if(res_val == true)
    {
        if(res_num > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }   
    else
    {
        return false;
    }
}

int[] userArrayBord(string[] array)
{
    int[] array_01 = new int[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = nextElArrBord($"Enter {array[idx]}: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}

int nextElArrBord(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = inpValidBord(elem);
        if(resVal == true)
        {
            num = Int32.Parse(elem);
        }
        else
        {
            Console.WriteLine("Ввод с ошибкой. Пробовать еще раз");
            continue;
        }      
    }
    return num;
}

bool inpValidBord(string num)
{
    bool res_val = Int32.TryParse(num, out int res_num);
    if(res_val == true)
    {
        return true;
    }   
    else
    {
        return false;
    }
}

while(true)
{
    Console.Write("\n");
    Console.WriteLine("\nEnter 's' to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] usArrayStrSize = {"cols", "rows"};
        int[] usArrayIntSize = userArray(usArrayStrSize);
        string[] usArrayStrBotd = {"min border", "max border"};
        int[] usArrayIntBord = userArrayBord(usArrayStrBotd);
        int[,] matriX = getRandMatrix(usArrayIntSize, usArrayIntBord);
        printMtrx(matriX);
        printMean(matriX);
    }    
}