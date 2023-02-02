// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//(допустимый вариант)
//6 16
//9 6

int[,] getMatrix(int[] array, Func<string, int> f)
{
    int[,] mtrx = new int[array[0], array[1]];

    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            mtrx[idx, jdx] = f($"Enter element matrix with ({idx + 1},{jdx + 1}) position");
        }
    }
    return mtrx;
}

/*int[,] transponseMtrx(int[,] mtrx)
{
    int[,] transpMtrx = new int[mtrx.GetLength(1), mtrx.GetLength(0)];
    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            transpMtrx[jdx, idx] = mtrx[idx, jdx];
        }
    }
    return transpMtrx;
}*/

void multMatrix(string[] sizeArray)
{
    int[][] sizeArrs = new int[2][];
    int[][,] mtrxArrs = new int[2][,];
    for(int idx = 0; idx < sizeArrs.Length; idx++)
    {
        Console.WriteLine($"{idx + 1} matrix sizen");
        sizeArrs[idx] = userArray(sizeArray, nextElArrSize);
        mtrxArrs[idx] = getMatrix(sizeArrs[idx], nextElArrSize);
    }
    if (mtrxArrs[0].GetLength(1) != mtrxArrs[1].GetLength(0)) throw new Exception("Can't multiplication this matrix!");
    int[,] multMtrx = new int[mtrxArrs[0].GetLength(0), mtrxArrs[1].GetLength(1)];
    for (int i = 0; i < mtrxArrs[0].GetLength(0); i++)
    {
        for (int j = 0; j < mtrxArrs[1].GetLength(1); j++)
        {
            for (int k = 0; k < mtrxArrs[1].GetLength(0); k++)
            {
                multMtrx[i,j] += mtrxArrs[0][i,k] * mtrxArrs[1][k,j];
            }
        }
    }

    Console.WriteLine("First matrix: ");
    printMtrx(mtrxArrs[0]);
    Console.WriteLine("Second matrix: ");
    printMtrx(mtrxArrs[1]);
    Console.WriteLine("Multiplication matrix: ");
    printMtrx(multMtrx);
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
            Console.WriteLine("Введена ошибка! пробуй еще раз!");
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
        multMatrix(usArrayStrSize);
    }    
}