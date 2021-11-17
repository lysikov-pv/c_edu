// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int EnterValueFromKeyboard(string preStr = "") // Возращает значение введенное с клавиатуры
{
    Console.Write(preStr);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int n, int min, int max) // Возвращает массив длинной n заполненный числами из диапазона [min;max)
{
    int[] a = new int[n];
    for (int i = 0; i < a.Length; ++i) a[i] = new Random().Next(min, max);
    return a;
}

void PrintArray(int[] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы массива
{
    Console.Write(preStr);
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.Write(postStr);
}

int CountItemsFromInterval(int[] arr, int min, int max) // Возращает количество элементов массива входящих в интервал [min,max]
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] >= min && arr[i] <= max) count++;
    return count;
}

int CountOddItems(int[] arr) // Возращает количество нечетных элементов в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0) count++;
    return count;
}

int CountOddIndex(int arrLength) // Возращает количество нечетных индексов в массиве
{
    int count = 0;
    for (int i = 1; i <= arrLength; i += 2) count++;
    return count;
}

void PrintMultiplOfPair(int[] arr) // Выводит произведение пар чисел в одномерном массиве
{
    for (int i = 0; i < arr.Length / 2; i++)
        Console.Write($"{arr[i] * arr[arr.Length - i - 1]} ");
    Console.WriteLine();
}

int exampleNum;
do
{
    Console.Clear();
    Console.WriteLine("36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел");
    Console.WriteLine("37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
    Console.WriteLine("38. Найти сумму чисел одномерного массива стоящих на нечетной позиции");
    Console.WriteLine("39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
    Console.WriteLine("0.  Выход");
    exampleNum = EnterValueFromKeyboard("Введите номер задачи для проверки: ");
    switch (exampleNum)
    {
        case 36: // Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел
            {
                int n = EnterValueFromKeyboard("Задайте длину массива: ");
                int[] arr = CreateArray(n, 100, 1000);
                PrintArray(arr, "Массив: ");
                Console.WriteLine($"Количество четных эл-ов: {CountOddItems(arr)}");

                break;
            }
        case 37: // В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
            {
                int n = EnterValueFromKeyboard("Задайте длину массива: "); // 123
                int[] arr = CreateArray(n, -100, 100);
                PrintArray(arr, "Массив: ");
                Console.WriteLine($"Количество эл-ов из отрезка [10,99]: {CountItemsFromInterval(arr, 10, 99)}");
                break;
            }
        case 38: // Найти сумму чисел одномерного массива стоящих на нечетной позиции
            {
                int n = EnterValueFromKeyboard("Задайте длину массива: ");
                Console.WriteLine($"Количество эл-ов на нечетной позиции: {CountOddIndex(n)}");
                break;
            }
        case 39: // Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
            {
                int n = EnterValueFromKeyboard("Задайте длину массива: ");
                int[] arr = CreateArray(n, 0, 10);
                PrintArray(arr, "Массив: ");
                Console.Write("Произведение пар: ");
                PrintMultiplOfPair(arr);
                break;
            }
    }
    if (exampleNum != 0) // Оставить решение задачи на экране пока не нажат Enter
    {
        Console.WriteLine("Нажмите Enter");
        Console.ReadLine();
    }
}
while (exampleNum != 0);