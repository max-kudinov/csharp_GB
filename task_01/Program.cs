Console.WriteLine("Enter 2 numbers: ");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
bool result = false;

if (numberA == numberB * numberB)
    result = true;
Console.WriteLine(result);
