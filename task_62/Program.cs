int[,] mtr = new int[15, 10];
fillMatrixSpiral(mtr, 0, 0, 0);
printMatrix(mtr);

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

// Работает для матриц любых размеров
void fillMatrixSpiral(int[,] matrix, int x, int y, int count)
{
    if (isCellValid(matrix, x, y) && matrix[y, x] == 0)
    {
        matrix[y, x] = ++count;
        if (!isCellValid(matrix, x, y - 1) || matrix[y - 1, x] != 0) // Идем вправо только если нельзя наверх
            fillMatrixSpiral(matrix, x + 1, y, count);
        fillMatrixSpiral(matrix, x, y + 1, count);
        fillMatrixSpiral(matrix, x - 1, y, count);
        fillMatrixSpiral(matrix, x, y - 1, count);
    }
}

bool isCellValid(int[,] matrix, int x, int y)
{
    if (x < 0 || y < 0 || x >= matrix.GetLength(1) || y >= matrix.GetLength(0))
        return false;
    return true;
}
