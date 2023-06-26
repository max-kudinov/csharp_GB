Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
