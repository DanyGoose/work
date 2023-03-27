double[] CreateArrayRnddouble(int size, int min, int max, int round = 1)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (min - max) + min;
        arr[i] = Math.Round(num, round);
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxNumber(double[] arr)
{
    double res = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > res) res = arr[i];
    }
    return res;
}

double MinNumber(double[] arr)
{
    double res = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < res) res = arr[i];
    }
    return res;
}

double DifMaxMin(double min, double max)
{
    double dif = max - min;
    return dif;
}

double Rounding(double num, int round = 1)
{
    num = Math.Round(num, round);
    return num;
}

double[] array = CreateArrayRnddouble(5, 1, 10, 2);
PrintArray(array);
Console.WriteLine();

double result = DifMaxMin(MinNumber(array), MaxNumber(array));
result = Rounding(result, 2);
Console.WriteLine(result);


/* массив из условия
double[] primer = {3.5, 7.1, 22.9, 2.3, 78.5};
PrintArray(primer);
Console.WriteLine();

Console.WriteLine(MinNumber(primer));
Console.WriteLine(MaxNumber(primer));

double finaly = DifMaxMin(MinNumber(primer), MaxNumber(primer));
Console.WriteLine(finaly);
*/