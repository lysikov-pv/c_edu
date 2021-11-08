// Лекция 2. Работа с массивами: заполнение, вывод, поиск элемента

void RandomFill(int[] array, int min, int max) // Заполняет массив значениями диапазона [min, max)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = new Random().Next(min, max);
    }
}
void Print(int[] array) // Выводит массив на экран
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int Find(int[] array, int findNum) // Возвращает номер позиции элемента в массиве
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
    Console.WriteLine("Нет совпадений");
}