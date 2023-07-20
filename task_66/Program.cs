int recSum(int m, int n)
{
    if (m <= n)
        return m + recSum(m + 1, n);
    else
        return 0;
}

Console.WriteLine(recSum(4, 8));
