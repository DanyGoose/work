int[] TransferNumber(int num)
{
    int size = 1;
    int tmp = num;

    while(tmp / 2 != 0)
    {
        tmp = tmp / 2;
        size++;
    }

    int[] arrTransferNumber = new int[size];
    for (int i = 0; i < arrTransferNumber.Length; i++)
    {
        arrTransferNumber[i] = num % 2;
        num = num / 2;
    }

    Array.Reverse(arrTransferNumber);
    return arrTransferNumber;
}

void PrintArray(int[] arrTransferNumber)
{
    Console.Write("[");
    for (int i = 0; i < arrTransferNumber.Length; i++)
    {
        if (i < arrTransferNumber.Length - 1) Console.Write($"{arrTransferNumber[i]}, ");
        else Console.Write($"{arrTransferNumber[i]}");
    }
    Console.Write("]");
}

int CheckNegativ(int num)
{
    if (num > -1) return num;
    else return num /= -1; 
}

Console.WriteLine("Введите целое положительное десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = CheckNegativ(number);  

int[] result = TransferNumber(number);
PrintArray(result);
