int[,,] array3D = fillRand3DArr(4, 4, 5);
if(array3D != null)
    print3DArr(array3D);
else
    Console.WriteLine("Not enough 2 digit numbers to fill an array");

int[,,] fillRand3DArr(int rows, int columns, int depth)
{
    int[] usedNums = new int[90];
    int usedIndex = 0;
    int[,,] arr3D = new int[rows, columns, depth];
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                int value = getRand2DigitNum(usedNums, usedIndex, 10, 99);
                if (value == -1)
                    return null;
                else
                {
                    arr3D[i, j, k] = value;
                    usedIndex++;
                }
            }
        }
    }
    return arr3D;
}

int getRand2DigitNum(int[] usedNums, int index, int start, int end)
{
    Random rnd = new Random();
    while (!isFull(usedNums))
    {
        int randNum;
        do
        {
            randNum = rnd.Next(start, end + 1);
        } while (isNumUsed(usedNums, randNum));
        usedNums[index] = randNum;
        return randNum;
    }
    return -1;
}

bool isNumUsed(int[] usedNums, int num)
{
    foreach (int usedNum in usedNums)
    {
        if (usedNum == num)
            return true;
    }
    return false;
}

bool isFull(int[] usedNums)
{
    foreach (int usedNum in usedNums)
    {
        if (usedNum == 0)
            return false;
    }
    return true;
}

void print3DArr(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
