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

int[,] rowsToColumns(int[,] matrix)
{
    int[,] changedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    if (matrix.GetLength(0) != matrix.GetLength(1))
        return changedMatrix;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            changedMatrix[j, i] = matrix[i, j];
        }
    }
    return changedMatrix;
}

int[,] mtr = getRandMatrix(5, 5, 10);
printMatrix(mtr);
Console.WriteLine();
int[,] newMtr = rowsToColumns(mtr);
printMatrix(newMtr);
