int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] Multiplication(int[] arr)
{
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] newArray = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int number = arr[i] * arr[arr.Length - 1 - i];
        newArray[i] = number;
    }

    if (arr.Length % 2 > 0)
    {
        int indexMedium = arr.Length / 2;
        newArray[size - 1] = arr[indexMedium];
    }

    return newArray;
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
Console.WriteLine();

int[] result = Multiplication(array);
PrintArray(result);