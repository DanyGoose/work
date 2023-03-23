Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; 1 <= num; i++)
    {
        sum = sum + 1; 
    }
    return sum;
}