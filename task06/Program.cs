Console.WriteLine("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber % 2 == 0)
{
    Console.WriteLine("Ваше число четное!");
}
else 
    Console.WriteLine("Ваше число нечетное!");