int ackermannFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return ackermannFunc(m - 1, 1);
    return ackermannFunc(m - 1, ackermannFunc(m, n - 1));
}

Console.WriteLine(ackermannFunc(3, 2));
