Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
    Console.WriteLine("кратно");
else
{
    int tmp = firstNumber % secondNumber;
    Console.WriteLine($"не кратно, остаток {tmp}");
}