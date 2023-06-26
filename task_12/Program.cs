Console.WriteLine("Enter 2 numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
    Console.WriteLine($"Number {num1} is a multiple of {num2}");
else
{
    int remainder = num1 % num2;
    Console.WriteLine($"The ramainder of {num1}/{num2} is {remainder}");
}
