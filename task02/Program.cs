Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.WriteLine($"{numberOne} больше, чем {numberTwo}");
}
else
    Console.WriteLine($"{numberTwo} больше, чем {numberOne}");