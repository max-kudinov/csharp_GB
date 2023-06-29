Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (n != 0){
    if (n < 0)
        n *= -1;

    while (count <= n)
    {
        Console.Write(count * count);
        if (count != n)
            Console.Write(", ");
        else
            Console.WriteLine(".");
        count++;
    }
}
else
    Console.WriteLine(0);
