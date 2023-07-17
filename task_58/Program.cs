int[,] mtr1 = getRandMatrix(2, 3, 10);
int[,] mtr2 = getRandMatrix(3, 2, 10);
printMatrix(mtr1);
Console.WriteLine();
printMatrix(mtr2);
Console.WriteLine();

int[,] product = multMatrices(mtr1, mtr2);
if (product == null)
    Console.WriteLine("Matrices cannot be multiplied");
else
    printMatrix(product);

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

int[,] multMatrices(int[,] matrA, int[,] matrB)
{
    if (matrA.GetLength(1) != matrB.GetLength(0))
        return null;

    int[,] product = new int[matrA.GetLength(0), matrB.GetLength(1)];
    int dotProduct;

    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
        dotProduct = 0;
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                dotProduct += matrA[i, k] * matrB[k, j];
            }
            product[i, j] = dotProduct;
        }
    }
    return product;
}
