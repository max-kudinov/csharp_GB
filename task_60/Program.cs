int[,,] array3D =
{
    {
        { 66, 25 },
        { 34, 41 }
    },
    {
        { 27, 90 },
        { 26, 55 }
    }
};

print3DArr(array3D);

void print3DArr(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
