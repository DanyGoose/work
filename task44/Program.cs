int[] FibonacciArray(int dig)
{
    int[] fibonacciArray = new int[dig];
    fibonacciArray[0] = 0; fibonacciArray[1] = 1;
    for (int i = 2; i < fibonacciArray.Length; i++)
    {
        fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
    }
    return fibonacciArray;
}

int CheckDigitPositive(int num)
{
    if (num < 0)
    {
        num *= -1;
        Console.WriteLine("Ваше число было изменено на положительное!");
    }
    if (num > -2 && num < 2)
    {
        num = 2;
        Console.WriteLine("Это не подходит, заменено на двойку!");
    }
    return num;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

Console.WriteLine("Сколько чисел фибоначчи нужно вывести? (введите целое положительное число): ");
int digit = Convert.ToInt32(Console.ReadLine());
digit = CheckDigitPositive(digit);

int[] result = FibonacciArray(digit);
PrintArray(result);