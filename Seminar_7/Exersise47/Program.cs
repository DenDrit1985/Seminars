// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] getRandMatrix(int[] sizeArray, double[] bordArray)
{
    double[,] mtrx = new double[sizeArray[0], sizeArray[1]];
    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            Random rnd = new Random();
            double d = Math.Round(bordArray[0] + rnd.NextDouble() * (bordArray[1] - bordArray[0]), 3);
            mtrx[idx, jdx] = d;
        }
    }
    return mtrx;
}
void printMtrx(double[,] matrix)
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
int[] userArraySize(string[] array)
{
    int[] array_01 = new int[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = nextElArrSize($"Enter {array[idx]} size: ");
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
            Console.WriteLine("Ввод ошибка.Введите снова");
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
        return true;
    }   
    else
    {
        return false;
    }
}
double[] userArrayBord(string[] array)
{
    double[] array_01 = new double[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        double nextEl = nextElArrBord($"Enter {array[idx]}: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}
double nextElArrBord(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    double num = 0.0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = inpValidBord(elem);
        if(resVal == true)
        {
            num = Double.Parse(elem);
        }
        else
        {
            Console.WriteLine("Ввод ошибка.Введите снова");
            continue;
        }      
    }
    return num;
}
bool inpValidBord(string num)
{
    bool res_val = Double.TryParse(num, out double res_num);
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
    Console.WriteLine("Введите 's' для старта или Введите 'q' для остановки: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Пока");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] arraySize = {"cols", "rows"};
        int[] szArray = userArraySize(arraySize);
        string[] arrayBord = {"min border", "max border"};
        double[] bordArray = userArrayBord(arrayBord);
        double[,] matriX = getRandMatrix(szArray, bordArray);
        printMtrx(matriX);
    }    
}
