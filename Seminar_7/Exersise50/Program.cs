// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

double[,] getRandMatrix(int[] sizeArray, int[] bordArray)
{
    double[,] mtrx = new double[sizeArray[0], sizeArray[1]];

    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            Random rnd = new Random();
            double d = Math.Round(bordArray[0] * 1.0 + rnd.NextDouble() * (bordArray[1] * 1.0 - bordArray[0] * 1.0), 3);
            mtrx[idx, jdx] = d;
        }
    }
    return mtrx;
}

void printMtrx(double[,] matrix, int[] coords)
{
    for(int idx = 0; idx < matrix.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < matrix.GetLength(1); jdx++)
        {
            Console.Write(matrix[idx, jdx] + " ");
        }
        Console.Write("\n");
    }
    if(coords[0] <= matrix.GetLength(0) && coords[1] <= matrix.GetLength(1))
    {
        Console.Write($"\nElement with coords - ({coords[0]}, {coords[1]}) = {matrix[coords[0], coords[1]]}");
    }
    else
    {
        Console.Write("Элемент с такими координатами ненайден");
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
            Console.WriteLine("Введена ошибка! Пробуй еще!");
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
            Console.WriteLine("Введена ошибка! Пробуй еще!");
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
        double[,] matriX = getRandMatrix(usArrayIntSize, usArrayIntBord);
        Console.WriteLine("\nTest check position element: ");
        string[] coorArrayStr = {"axis X", "axis Y"};
        int[] res_val = userArray(coorArrayStr);
        printMtrx(matriX, res_val);
    }    
}