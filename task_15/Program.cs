Console.WriteLine("Enter day of the week number:");
int weekNum = Convert.ToInt32(Console.ReadLine());

if (weekNum > 7 || weekNum < 1)
    Console.WriteLine("That day of the week doesn't exist");
else if (weekNum > 5)
    Console.WriteLine("Weekend");
else
    Console.WriteLine("Weekday");
