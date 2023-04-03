int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double[] SearchArithmeticMean(int[,] arr, int round)
{
    double[] arithmeticMean = new double[arr.GetLength(1)];
    double tmp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            tmp += arr[j, i];
        }
        arithmeticMean[i] = tmp / arr.GetLength(0);
        arithmeticMean[i] = Math.Round(arithmeticMean[i], round);
    }
    return arithmeticMean;
}

int[,] arrayMatrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(arrayMatrix);

Console.WriteLine();

double[] result = SearchArithmeticMean(arrayMatrix, 1);
Console.Write("Среднее арифметическое каждого столбца -> ");
PrintArray(result);