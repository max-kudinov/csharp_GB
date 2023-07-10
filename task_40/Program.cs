Console.Write("Enter side a: ");
int sideA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter side b: ");
int sideB = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter side c: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool result = isTriangle(sideA, sideB, sideC);
Console.WriteLine(result);

bool isTriangle(int a, int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
        return false;
    if (a + b <= c || b + c <= a || c + a <= b)
        return false;
    return true;
}
