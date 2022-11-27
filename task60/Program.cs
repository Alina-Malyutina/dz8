
void PrintArrayWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
            Console.Write($"{array[i, j, m]} ({i}, {j}, {m})" );

            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}

int [,,] array = new int [3, 3, 3];
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
            array [i,j,m] = new Random().Next(4,10) * new Random().Next(3,10);
            }
        }
    }
PrintArrayWithIndex(array);


