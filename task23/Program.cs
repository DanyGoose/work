Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) Cube(number);
else Console.WriteLine("НЕ ПОДХОДИТ!");

void Cube(int i)
{
    int tmp = 1;
    while (tmp <= i)
    {
        int res = tmp * tmp * tmp;
        Console.WriteLine($"{res} ");
        tmp++;
    }
}