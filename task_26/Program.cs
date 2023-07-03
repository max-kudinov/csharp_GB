Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

int digits = 0;

if (num < 0)
    num *= -1;
else if (num == 0)
    digits = 1;

while (num != 0)
{
    num /= 10;
    digits++;
}

Console.WriteLine($"The number has {digits} digits");
