void RandomFill(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = new Random().Next(min, max);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Find(int[] array, int findNum)
{
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] == findNum) return i;
    }
    return -1;
}

int[] array = new int[10];
RandomFill(array, 0, 10);
Print(array);
int result = Find(array, 3);
if (result != -1)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("no matches");
}
