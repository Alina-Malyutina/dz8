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

int SearchRowWithMinSumOfElements(int[,] array)
{
    int[] sumOfElemsInRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; // count sum of elements in row
        }
    sumOfElemsInRows[i] = sum; // add sum of rows to new array
    }
    int max = sumOfElemsInRows[0];
    int imax = 0;
    for (int n = 0; n < sumOfElemsInRows.Length; n++) // search row with max sum of elements
    {
        if (sumOfElemsInRows[n]>max)
        {
            max = sumOfElemsInRows[n];
            imax = n;
        }
    }
    return imax+1; //row number must begin from 1
}

int [,] array = new int [5,5];
FillArrayRowColByRandom(array);
PrintArray(array);
Console.WriteLine();
int maximum = SearchRowWithMinSumOfElements(array);
Console.WriteLine($"Row with maximum sum of elements is {maximum}");