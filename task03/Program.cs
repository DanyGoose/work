Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number == 0) 
{
    Console.WriteLine("Такого дня недели несуществует");
}
if (number == 1)
{
    Console.WriteLine("Ваш день - понедельник!");
}
if (number == 2)
{
    Console.WriteLine("Ваш день - вторник!");
}
if (number == 3)
{
    Console.WriteLine("Ваш день - среда!");
}
if (number == 4)
{
    Console.WriteLine("Ваш день - четверг!");
}
if (number == 5)
{
    Console.WriteLine("Ваш день - пятница!");
}
if (number == 6)
{
    Console.WriteLine("Ваш день - суббота!");
}
if (number == 7)
{
    Console.WriteLine("Ваш день - воскресенье!");
}