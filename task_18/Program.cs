string getRange(int quadrant)
{
    if (quadrant == 1) return "x > 0; y > 0";
    else if (quadrant == 2) return "x < 0; y > 0";
    else if (quadrant == 3) return "x < 0; y < 0";
    else if (quadrant == 4) return "x > 0; y < 0";
    else return "invalid value";
}

Console.WriteLine("Enter quadrant");
int quadrant = Convert.ToInt32(Console.ReadLine());

string result = getRange(quadrant);
Console.WriteLine(result);
