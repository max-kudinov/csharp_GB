Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= N)
{
    Console.Write(count);
    if (count != N && count != N - 1)
        Console.Write(", ");
    else
        Console.WriteLine("\nDone!");
    count += 2;
}
