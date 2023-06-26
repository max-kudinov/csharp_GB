Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 == 0)
    Console.WriteLine("Third digit doesn't exist");
else
{
    while (num / 1000 != 0)
        num /= 10;
    int thirdDigit = num % 10;
    Console.WriteLine(thirdDigit);
}
