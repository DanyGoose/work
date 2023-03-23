Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую нужно возвести это число: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree > 0)
{
    int res = Exponentiation(number, degree);
    Console.WriteLine($"{number} в степени {degree} -> {res}");
}
else Console.WriteLine("Степень должна быть положительным числом!");

int Exponentiation(int num, int deg)
{
    int tmp = 1;
    for (int i = 0; i < deg; i++)
    {
        tmp = tmp * num;
    }
    return tmp;
}