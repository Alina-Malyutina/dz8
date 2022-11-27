void FillArrayRowColByRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MyltiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }    
    return matrix3;
}
Console.WriteLine("This program assepts quantity of rows and columns in two matrixes and multiplies this matrixes.");
Console.WriteLine("Quantity of columns in first matrix must be equal to quantity of rows of second matrix.");
Console.Write("Enter quantitiy of rows for first matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantitiy of columns for first matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantitiy of rows for second matrix: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantitiy of columns for second matrix: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[k, l];
FillArrayRowColByRandom(matrix1);
FillArrayRowColByRandom(matrix2);
PrintArray(matrix1);
PrintArray(matrix2);
int [,] matrix3 = MyltiplyMatrixes(matrix1, matrix2);
PrintArray(matrix3);