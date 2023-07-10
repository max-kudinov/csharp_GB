int[] generateArray(int length, int start, int end)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = rnd.Next(start, end + 1);
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] reverseArray(int[] array)
{
    int[] reversedArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        reversedArr[i] = array[array.Length - 1 - i];
    return reversedArr;
}

int[] arr = generateArray(10, -100, 100);
printArray(arr);
int[] revArr = reverseArray(arr);
printArray(revArr);
