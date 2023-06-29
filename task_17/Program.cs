int getQuarter(int x, int y) 
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    return 0;
}

Console.WriteLine("Enter x coordinate");
int userX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y coordinate");
int userY = Convert.ToInt32(Console.ReadLine());

int result = getQuarter(userX, userY);

if (result > 0)
    Console.WriteLine($"[{userX};{userY}] is in {result} quadrant");
else
    Console.WriteLine($"[{userX};{userY}] is in the border");
