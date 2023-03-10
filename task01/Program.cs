Console.Write("Введите первое целое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе целое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int square = numberTwo * numberTwo;
if (square == numberOne)
{
    Console.WriteLine("Квадрат второго числа равен первому числу"); 
} 
else
{
    Console.WriteLine("Квадрат второго числа не равен первому числу");
}