void recCount(int n)
{
    if (n >= 1)
    {
        Console.Write(n + " ");
        recCount(n - 1);
    }
}

recCount(8);
