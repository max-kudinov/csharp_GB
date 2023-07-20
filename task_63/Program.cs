void recCount(int count, int n)
{
    if(count <= n) {
        Console.WriteLine(count);
        recCount(count + 1, n);
    }
}

recCount(1, 5);
