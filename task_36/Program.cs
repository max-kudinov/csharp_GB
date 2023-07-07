int[] array = createRandArr(0, 10);
printArr(array);
int sum = sumOfOddIndexElements(array);
Console.WriteLine(sum);

int[] createRandArr(int min, int max)
{
    Random rnd = new Random();
    int size = rnd.Next(5, 20);
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = rnd.Next(min, max + 1);
    return arr;
}

int sumOfOddIndexElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
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
