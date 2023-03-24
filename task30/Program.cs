RandArray();

void RandArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        int number = new Random().Next(0, 2);
        array[i] = number; 
        Console.Write(array[i] + " ");
    }
}
