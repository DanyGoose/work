Console.WriteLine("Введите целое положительное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int composition = Composition(number);
    Console.WriteLine($"произведение чисел от 1 до {number} -> {composition}");
}
else Eror();

int Composition(int num)
{
    int res = 1;
    int tmp = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * tmp;
        tmp++;
    }
    return res;
}

void Eror()
{
    Console.WriteLine("Ваше число не подходит!");
}