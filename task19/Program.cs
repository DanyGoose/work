Console.WriteLine("Введите целое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000) YesNo(number);
else Console.WriteLine("Число не подходит!");

void YesNo(int num0)
{
    int num1 = num0 / 10000;
    int num2 = num0 % 10;
    if (num1 == num2)
    {
        num1 = num0 / 1000 % 10;
        num2 = num0 % 100 / 10;
        if (num1 == num2)  Console.WriteLine("Палиндром");
    }
    else Console.WriteLine("Не палиндром");
} 