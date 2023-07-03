void fillRandomArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 100);
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] rndArr = new int[8];
fillRandomArray(rndArr);
printArray(rndArr);
