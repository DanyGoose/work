RandArray();

void RandArray()
{
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 101); 
        Console.Write(array[i] + " ");
    }
}