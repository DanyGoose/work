Console.WriteLine("Введите номер четветри (от 1 до 4): ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = Quarter(quarter);
Console.WriteLine(result);

string Quarter(int quart)
{
    if(quart == 1) return "x > 0 и y > 0";
    if(quart == 2) return "x < 0 и y > 0";
    if(quart == 3) return "x < 0 и y < 0";
    if(quart == 4) return "x > 0 и y < 0";
    return "недопустимое значение!";
}
