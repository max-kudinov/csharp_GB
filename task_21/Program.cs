char[] axes = { 'x', 'y', 'z' };
int[,] coordinates = new int[2, 3];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter {axes[j]} coordinate: ");
        coordinates[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

double deltaX = coordinates[0, 0] - coordinates[1, 0];
double deltaY = coordinates[0, 1] - coordinates[1, 1];
double deltaZ = coordinates[0, 2] - coordinates[1, 2];

double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));
distance = Math.Round(distance, 2);

Console.WriteLine($"The distance is: {distance}");
