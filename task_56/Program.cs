int[,] mtr = getRandMatrix(5, 6, 10);
printMatrix(mtr);
int[] sums = calcRowsSum(mtr);
int rowNum = findLowestSumRow(sums);
Console.WriteLine($"The lowest sum row is {rowNum}");

int[,] getRandMatrix(int rows, int columns, int deviation)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(-deviation, deviation + 1);
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    Console.Write("[ ]\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
        Console.Write($"[{i + 1}]" + "\t");

    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i + 1}]" + "\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

int[] calcRowsSum(int[,] matrix)
{
    int[] sumArr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArr[i] += matrix[i, j];
        }
    }
    return sumArr;
}

int findLowestSumRow(int[] sums)
{
    int minIndex = 0;
    for (int i = 1; i < sums.Length; i++)
    {
        if(sums[i] < sums[minIndex])
            minIndex = i;
    }
    return minIndex + 1;
}
