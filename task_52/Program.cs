int[,] mtr = getRandMatrix(3, 4, 10);
printMatrix(mtr);
double[] meanResult = calcMean(mtr);
printMean(meanResult);

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

double[] calcMean(int[,] matrix)
{
    double[] mean = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
            mean[i] += matrix[j, i];
        mean[i] /= matrix.GetLength(0);
    }
    return mean;
}

void printMean(double[] meanArr)
{
    Console.Write("Mean:  ");
    for (int i = 0; i < meanArr.Length; i++)
        Console.Write(Math.Round(meanArr[i], 1) + "\t");
}
