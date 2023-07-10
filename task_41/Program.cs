Console.WriteLine("Enter quantity of entered numbers: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[quantity];
for (int i = 0; i < quantity; i++)
{
    Console.Write("Enter a number: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int positives = countPositive(numbers);
Console.WriteLine(positives);

int countPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}
