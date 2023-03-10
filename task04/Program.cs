Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo && numberOne > numberThree)
{
    Console.WriteLine($"{numberOne} больше, чем остальные числа");
}
else if (numberTwo > numberThree)
{
    Console.WriteLine($"{numberTwo} больше, чем остальные числа");
}
else
    Console.WriteLine($"{numberThree} больше, чем остальные числа");
