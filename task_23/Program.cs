Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

if (num != 0)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.Write(Math.Pow(i, 3));
            if (i != num)
                Console.Write(", ");
            else
                Console.WriteLine(".");
        }
    }
    else
    {
        for (int i = num; i <= 1; i++)
        {
            Console.Write(Math.Pow(i, 3));
            if (i != 1)
                Console.Write(", ");
            else
                Console.WriteLine(".");
        }
    }
}
else
    Console.WriteLine(0);
