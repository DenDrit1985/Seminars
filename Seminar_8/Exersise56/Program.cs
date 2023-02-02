// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

double[,] getMatrix(int[] array, Func<string, double> f)
{
    double[,] mtrx = new double[array[0], array[1]];

    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            mtrx[idx, jdx] = f($"Enter element matrix with ({idx + 1},{jdx + 1}) position");
        }
    }
    return mtrx;
}

void minSumRow(double[,] matrix)
{
    double minSumRow = double.PositiveInfinity;
    double minSumRowIdx = 0.0;
    double[] sumElRows = new double[matrix.GetLength(0)];
    for(int idx = 0; idx < matrix.GetLength(0); idx++)
    {
        double sumRow = 0.0;
        for(int jdx = 0; jdx < matrix.GetLength(1); jdx++)
        {
            sumRow += matrix[idx, jdx];
        }
        if(sumRow < minSumRow)
        {
            minSumRowIdx = idx;
        }
        minSumRow = sumRow;
        sumElRows[idx] = sumRow;
    }
    double difArr = 0.0;
    for(int idx = 0; idx < sumElRows.Length - 1; idx++)
    {
        difArr = sumElRows[idx] - sumElRows[idx + 1];
        if(difArr == 0.0)
        {
            if(idx == sumElRows.Length - 2)
            {
                Console.Write("\nAll rows sum '==' ");
            }
        }
        else
        {
            Console.Write($"Min sum from {minSumRowIdx + 1} row");
            break;
        }
    }
    
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

int[] userArraySize(string[] array, Func<string, int> f)
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
            Console.WriteLine("Ввод с ошибкой! Пробуйте еще раз!");
        }
    }
    return num;
}

double nextElArr(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    double num = 0.0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = Double.TryParse(elem, out num);
        if(resVal == false)
        {
            Console.WriteLine("Ввод с ошибкой! Пробуйте еще раз!");
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
        string[] usArrayStrSize = {"rows", "cols"};
        int[] usArrayIntSize = userArraySize(usArrayStrSize, nextElArrSize);
        double[,] matriX = getMatrix(usArrayIntSize, nextElArr);
        printMtrx(matriX);
        minSumRow(matriX);
    }    
}