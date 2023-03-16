Console.WriteLine("Введите целое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = number % 100 / 10;
Console.WriteLine(number);