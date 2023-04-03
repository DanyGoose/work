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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintPosition(int[,] arr, int rows, int columns)
{
    Console.WriteLine();
    if (arr.GetLength(0) > rows && arr.GetLength(1) > columns) Console.WriteLine($"ваш элемент -> {arr[rows, columns]}");
    else Console.WriteLine("Такой позиции в этом массиве нет!");
}

Console.WriteLine("Задайте номер позиции по вертикали(целое положительное число, либо 0): ");
int vertical = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте номер позиции по горизонтали(целое положительное число, либо 0): ");
int horizontal = Convert.ToInt32(Console.ReadLine());

int[,] arrayMatrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(arrayMatrix);
PrintPosition(arrayMatrix, vertical, horizontal);