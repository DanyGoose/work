Console.WriteLine("Введите целое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 || number < -99)
{
    if (number < 1000 && number > -1000) 
    {
        number = number % 10;
        Console.WriteLine(number);
    }
    else
    {
        while(number > 999 || number < -1000)
        {
            number = number / 10;
        }
        number = number % 10;
        Console.WriteLine(number);
    }
}
else Console.WriteLine("Третьей цифры нет");