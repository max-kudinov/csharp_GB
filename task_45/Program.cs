int[] copyArr(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        copyArray[i] = arr[i];
    return copyArray;
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

int[] array = { 1, 2, 3, 4, 5 };
printArr(array);
int[] cpyArray = copyArr(array);
printArr(cpyArray);

Console.WriteLine();
array[0] = 69;
printArr(array);
printArr(cpyArray);
