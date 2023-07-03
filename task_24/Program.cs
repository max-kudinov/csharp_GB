Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

int getSumOfSeries(int start, int end)
{
    int sum = 0;
    for(int i = start; i <= end; i++)
        sum += i;
    return sum;
}

Console.WriteLine(getSumOfSeries(1, num));
