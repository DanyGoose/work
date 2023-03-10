Console.WriteLine("Введите целое положительное число число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber > 0)
{
    while (userNumber > 0)
    {
        if (userNumber % 2 > 0)
        {
            userNumber--;
        }
        else
        {
            Console.Write($"{userNumber} ");
            userNumber--;
        }
    }
}
else
    Console.Write("Это число не подходит!");