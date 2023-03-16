Console.WriteLine("Введите день недели (от 1 до 7)");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8 && number > 0)
{
    if (number > 5) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else
    Console.WriteLine("ОТ 1 ДО 7 !!");