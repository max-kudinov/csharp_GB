Console.Write("Enter a number: ");
int decNum = Convert.ToInt32(Console.ReadLine());

int decToBin(int dec)
{
    int shift = 1;
    int binary = 0;

    while (decNum != 0)
    {
        binary += (decNum % 2) * shift;
        shift *= 10;
        decNum /= 2;
    }
    return binary;
}

int binNum = decToBin(decNum);
Console.WriteLine($"Binary form is {binNum}");
