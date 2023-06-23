Console.WriteLine("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine($"The last digit is: {result}");
}
else
    Console.WriteLine("Not a three-digit number");
