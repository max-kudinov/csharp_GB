Console.Write("Enter a base: ");
int a = Convert.ToInt32(Console.ReadLine());
int b;
do
{
    Console.Write("Enter a natural power: ");
    b = Convert.ToInt32(Console.ReadLine());
} while (b < 1);

int result = a;
for (int i = 1; i < b; i++)
    result *= a;

Console.WriteLine($"{a} in power {b} is {result}");
