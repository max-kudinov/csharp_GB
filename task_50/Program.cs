int[,] mtr = getRandMatrix(5, 7, 10);
printMatrix(mtr);

Console.Write("Enter a row: ");
int row = Convert.ToInt32(Console.ReadLine());
row -= 1;

Console.Write("Enter a column: ");
int column = Convert.ToInt32(Console.ReadLine());
column -= 1;

if(isValidPosition(mtr, row, column))
    Console.WriteLine($"Your value is {mtr[row, column]}");
else
    Console.WriteLine("Your position doesn't exist in the matrix");

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

bool isValidPosition(int[,] matrix, int row, int column)
{
    if (row >= matrix.GetLength(0) 
            || column >= matrix.GetLength(1) 
            || row < 0 
            || column < 0)
    {
        return false;
    }
    return true;
}
