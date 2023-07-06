int[] array = getRandArr(123, 999);
printArr(array);
Console.WriteLine(countElementsInRange(array, 10, 99));

int[] getRandArr(int length, int deviation)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rnd.Next(-deviation, deviation + 1);
    return arr;
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
    Console.ForegroundColor = ConsoleColor.White;
}

int countElementsInRange(int[] arr, int start, int end)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element >= start && element <= end)
            count++;
    }
    return count;
}
