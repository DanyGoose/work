Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) 
{
    Console.WriteLine("Ваш день - понедельник!");
}
else if (number == 2)
{
    Console.WriteLine("Ваш день - вторник!");
}
else if (number == 3)
{
    Console.WriteLine("Ваш день - среда!");
}
else if (number == 4)
{
    Console.WriteLine("Ваш день - четверг!");
}
else if (number == 5)
{
    Console.WriteLine("Ваш день - пятница!");
}
else if (number == 6)
{
    Console.WriteLine("Ваш день - суббота!");
}
else if (number == 7)
{
    Console.WriteLine("Ваш день - воскресенье!");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}