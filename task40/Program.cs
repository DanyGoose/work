bool CheckTriangle(int a, int b, int c)
{
    if (a < b + c
        && b < a + c
        && c < a + b) return true;
    return false;
}

void PrintAnswer(bool qustion)
{
    if (qustion == true) Console.WriteLine("Такой треугольник возможен!");
    else Console.WriteLine("Такого треугольника быть не может!");
}

Console.WriteLine("Введите сторону A: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool checkTriangle = CheckTriangle(sideA, sideB, sideC);
PrintAnswer(checkTriangle);
