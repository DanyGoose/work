Console.Write("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber > 0)
{
    int tmp = userNumber * -1; 
    while ( tmp <= userNumber )
    {
        Console.Write($"{tmp} ");
        tmp++;
    }
}
else
{
    int tmp = userNumber * -1;
    while ( userNumber <= tmp )
    {
        Console.Write($"{userNumber} ");
        userNumber++;
    }
}