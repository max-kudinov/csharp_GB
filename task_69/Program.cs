int APowB(int a, int b)
{
    if (b == 1)
        return a;
    else
        return a * APowB(a, b - 1);
}

Console.WriteLine(APowB(2, 5));
