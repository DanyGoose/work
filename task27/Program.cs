Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Remains(number);
Console.WriteLine(result);

int Remains(int num)
{
    int tmp = 0;
    int res = 0;
    while (num > 9 || num < -9)
    {
        tmp = num % 10;
        res = res + tmp;
        num = num / 10;
    }
    res = res + num;
    return res;
}
