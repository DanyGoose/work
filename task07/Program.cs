Console.Write("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if ( userNumber > 99 && userNumber < 1000 )
{
    userNumber = userNumber % 10;
    Console.WriteLine(userNumber);
}
else 
    Console.WriteLine("Вы ввели не трехзначное число!");