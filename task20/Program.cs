Console.WriteLine("Введите координаты точки A");
Console.Write("по X: ");
int aXCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("по Y: ");
int aYCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("по X: ");
int bXCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("по Y: ");
int bYCoordinate = Convert.ToInt32(Console.ReadLine());

double result = Distance(aXCoordinate, aYCoordinate, bXCoordinate, bYCoordinate);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 2D пространстве -> {resRound}");

double Distance(int x1, int y1, int x2, int y2)
{
    int x0 = x1 - x2;
    int y0 = y1 - y2;
    double c = Math.Sqrt(x0 * x0 + y0 * y0);
    return c;
}

