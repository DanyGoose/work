int[] NumbersUsers(int digitNum)
{
    int[] numbersUsers = new int[digitNum];
    Console.WriteLine("Вводите сами числа: ");
    for (int i = 0; i < numbersUsers.Length; i++)
    {
        numbersUsers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbersUsers;
}

int CheckPositive(int[] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) tmp++;
    }
    return tmp;
}

int CheckDigitPositive(int num)
{
    if (num < 0)
    {
        num *= -1;
        Console.WriteLine("Ваше число было изменено на положительное!");
    }
    if (num == 0) 
    {
        num++;
        Console.WriteLine("Это не подходит, прибавлена единица!");
    }
    return num;
}

Console.WriteLine("Сколько будет чисел? (Введите положительное натуральное число): ");
int digit = Convert.ToInt32(Console.ReadLine());
digit = CheckDigitPositive(digit);

int[] resultNumbers = NumbersUsers(digit);
digit = CheckPositive(resultNumbers);
Console.WriteLine($"чисел больше 0: {digit}");
