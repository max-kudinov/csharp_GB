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

void reverseMatrix(int[,] matrix)
{
    int rowLen = matrix.GetLength(1);
    int lastRow = matrix.GetLength(0) - 1;
    for(int i = 0; i < rowLen; i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
}

int[,] mtr = getRandMatrix(5, 7, 10);
printMatrix(mtr);
Console.WriteLine();
reverseMatrix(mtr);
printMatrix(mtr);
