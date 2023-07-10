Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());

void printFib(int n)
{
    int prevSum2 = 0;
    int prevSum1 = 1;
    int sum = 0;
    Console.Write(prevSum2 + " ");
    Console.Write(prevSum1 + " ");

    for (int i = 0; i < n - 2; i++)
    {
        sum = prevSum1 + prevSum2;
        Console.Write(sum + " ");
        prevSum2 = prevSum1;
        prevSum1 = sum;
    }
}

printFib(n);
