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

bool CheckNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
    }
    return false;
}

Console.WriteLine("Введите число для проверки");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(10,-10, 10);
PrintArray(array);
Console.WriteLine();

if (CheckNumber(array, number) == true) Console.WriteLine($"{number} присутствует в массиве");
else Console.WriteLine($"{number} в массиве нет");