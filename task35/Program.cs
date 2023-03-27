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

int SearchElements(int[] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 9 && arr[i] < 100) tmp++;
    }
    return tmp;
}

int[] array = CreateArrayRndInt(123, -200, 200);
PrintArray(array);

int searchElements = SearchElements(array);
Console.Write($" --> {searchElements}");