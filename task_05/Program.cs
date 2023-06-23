Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
