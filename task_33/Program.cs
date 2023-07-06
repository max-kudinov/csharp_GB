int num = 5;
int[] array = getRandArr(10, 10);
printArr(array);
bool result = findNumber(array, num);
Console.WriteLine(result);

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

bool findNumber(int[] arr, int number)
{
    foreach (int element in arr)
    {
        if (element == number)
            return true;
    }
    return false;
}
