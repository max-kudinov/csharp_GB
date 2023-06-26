Console.WriteLine("Enter 3 digit number:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
    Console.WriteLine("Not a 3 digit number");
else
{
    num %= 100;
    num /= 10;
    Console.WriteLine($"Second digit is {num}");
}
