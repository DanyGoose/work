Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = Digit(number);
Console.WriteLine($"Кол-во цифр в числе -> {digit}");

int Digit (int num)
{
    int i = 0;
    while (num != 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

