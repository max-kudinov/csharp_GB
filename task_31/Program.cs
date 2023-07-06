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

int sumOfElements(int[] arr, int multiply)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] * multiply > 0)
            sum += arr[i];
    }
    return sum;
}

int[] array = getRandArr(12, 9);
printArr(array);
System.Console.WriteLine();
int positiveSum = sumOfElements(array, 1);
System.Console.WriteLine($"Sum of positive elements: {positiveSum}");

int negativeSum = sumOfElements(array, -1);
System.Console.WriteLine($"Sum of negative elements: {negativeSum}");
