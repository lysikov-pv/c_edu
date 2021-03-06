int GetN(string str) // Ввод элемента
{
    Console.Write(str + "= ");
    int x = int.Parse(Console.ReadLine());
    return x;
}
void RandomFill(int[] array, int min, int max) // Заполнение массива числами из диапазона [min;max)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = new Random().Next(min, max);
    }
}
void Print(int[] array) // Вывод массива на экран
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int Find(int[] array, int findNum) // Возвращает номер элемента в массиве по значению
{
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] == findNum) return i;
    }
    return -1;
}
int FindCount(int[] array, int findNum) // Считает количество вхождений элемента в массив
{
    int count = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] == findNum) count++;
    }
    return count;
}
int CountEllement(int[] array, int findNum) // Считает сколько символов между 1 и последним вхождением элемента в массив
{
    int first = -1;
    int last = -1;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] == findNum)
        {
            if(first == -1)
            {
                first = i;
            }
            else
            {
                last = i;
            }
        }
    }
    int result = last-first-1;
    if(result < 0) result=0;
    return result;
}

int n = GetN("N");
int k = GetN("K");
int[] array = new int[n];
RandomFill(array, -10, 10);
Print(array);

Console.Write("Ellement " + k + " included " + FindCount(array, k) + " times");
Console.WriteLine();
Console.Write("Between first and last " + CountEllement(array, k) + " elements");
// int result = Find(array, 3);
// if (result != -1)
// {
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("no matches");
// }