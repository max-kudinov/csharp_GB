double[,] randMatrix = getRandMatrix(6, 9, 420);
printMatrix(randMatrix);

double[,] getRandMatrix(int rows, int columns, int deviation)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double rand = new Random().NextDouble() * (2 * deviation) - deviation;
            rand = Math.Round(rand, 1);
            matrix[i, j] = rand; 
        }
    }
    return matrix;
}

void printMatrix(double[,] matrix)
{
    Console.Write("[ ]\t\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
        Console.Write($"[{i + 1}]" + "\t\t");

    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i + 1}]" + "\t\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t\t");
        Console.WriteLine();
    }
}
