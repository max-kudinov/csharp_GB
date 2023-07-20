void nSums(int a, int b, int n)
{
    if (n > 0)
    {
        Console.Write(a + " ");
        int temp = b;
        b = a + b;
        a = temp;
        nSums(a, b, n - 1);
    }
}

nSums(6, 10, 4);
