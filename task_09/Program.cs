int randomNumber = new Random().Next(10, 100);
Console.WriteLine($"The random number is {randomNumber}");
Console.Write("The largest digit is: ");

int tens = randomNumber / 10;
int ones = randomNumber % 10;

int max = tens;

if (ones > tens)
    max = ones;

Console.WriteLine(max);
