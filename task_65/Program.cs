void recCount(int start, int end)
{
    if(start <= end) {
        Console.Write(start + " ");
        recCount(start + 1, end);
    }
}

recCount(13, 22);
