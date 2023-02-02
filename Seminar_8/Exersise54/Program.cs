// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void orderMatrix(int[,] matrix)
{
    for(int idx = 0; idx < matrix.GetLength(0); idx++)
    {
        int jdx = 0;
        while(jdx < matrix.GetLength(1) - 1)
        {
            if(matrix[idx, jdx] < matrix[idx, jdx + 1])
            {
                int tmp = matrix[idx, jdx];
                matrix[idx, jdx] = matrix[idx, jdx + 1];
                matrix[idx, jdx + 1] = tmp;
                jdx = 0;
            }
            else
            {
                jdx += 1;
            }
        }
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
            Console.WriteLine("Enter error! Try again!");
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
        int[] usArrayIntSize = userArray(usArrayStrSize, nextElArrSize);
        int[,] matriX = getMatrix(usArrayIntSize, nextElArrSize);
        printMtrx(matriX);
        orderMatrix(matriX);
        Console.Write("\n");
        printMtrx(matriX);
    }    
}