int[] array = createRandArr(100, 999);
printArr(array);
int quantity = calcEvenNumbers(array);
Console.WriteLine($"There are {quantity} even numbers in array");

int[] createRandArr(int min, int max)
{
    Random rnd = new Random();
    int size = rnd.Next(5, 20);
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = rnd.Next(min, max + 1);
    return arr;
}

int calcEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

void printArr(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.WriteLine(arr[i] + "]");
    }
    Console.ForegroundColor = ConsoleColor.Magenta;
}
