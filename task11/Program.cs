int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int tmp = number / 100;
number = number % 10;
Console.Write(tmp);
Console.Write(number);