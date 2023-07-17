int[,] mtr = getRandMatrix(6, 5, 3);                   // генерим рандомную матрицу
printMatrix(mtr);
int[] array = matrixToArray(mtr);                       // превращаем ее в одномерный массив
bubbleSort(array);                                      // сортируем его по порядку
Console.WriteLine();
int elementsNum = countElements(array);                 // находим кол-во разных элементов
int[,] dictionary = createDict(array, elementsNum);     // создаем "словарь" (двумерный массив, где индекс 0 - значение, а 1 - кол-во повторений)
printDict(dictionary);

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

int countElements(int[] array)
{
    int count = 1;
    int lastElement = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] != lastElement)
        {
            count++;
            lastElement = array[i];
        }
    }
    return count;
}

int[,] createDict(int[] array, int len)
{
    int[,] dict = new int[len, 2];
    int index = 0;
    dict[index, 1]++;
    int lastElement = array[0];
    dict[0, 0] = lastElement;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] != lastElement)
        {
            index++;
            dict[index, 0] = array[i];
            dict[index, 1]++;
            lastElement = array[i];
        }
        else
            dict[index, 1]++;
    }
    return dict;
}

void printDict(int[,] dict)
{
    for (int i = 0; i < dict.GetLength(0); i++)
    {
        Console.WriteLine($"Number {dict[i, 0]} is present {dict[i, 1]} time(s)");
    }
}

int[] matrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
    }
    return array;
}

void bubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if(arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
