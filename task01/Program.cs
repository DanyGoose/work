Console.Write("Введите первое целое число:");
int numberOne = Convert.ToInt32(Console.WriteLine());
Console.Write("Введите второе целое число:");
int numberTwo = Convert.ToInt32(Console.WriteLine());
int square = numberTwo * numberTwo;
if (numberOne == square)
{
    Console.ReadLine("квадрат второго числа равен первому числу.");
}
else 
{
    Console.ReadLine("квадрат второго числа не равен первому числу.");
}