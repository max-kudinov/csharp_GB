Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

int productOfRange(int start, int end)
{
    int product = 1;
    for(int i = start; i <= end; i++)
        product *= i;
    return product;
}

int result = productOfRange(1, num);
Console.WriteLine(result);
