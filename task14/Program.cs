Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiplication(number, 7, 23);
Console.WriteLine(result ? "Кратно" : "Не кратно");

bool Multiplication(int firstNumber, int secondNumber, int thirdNumber)
{
    return firstNumber % secondNumber == 0 && firstNumber % thirdNumber == 0;
}

//if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно");
//else Console.WriteLine("Не кратно");