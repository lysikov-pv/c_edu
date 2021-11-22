// 45. Показать числа Фибоначчи

int[] FillArrayFibonacci(int n) // Выводит первые N чисел Фибонначи. N > 0.
{
    int[] result = new int[n];
    result[0] = 0;
    if (n > 1) result[1] = 1;
    for (int i = 2; i < n; i++)
        result[i] = result[i - 1] + result[i - 2];
    return result;
}

bool IsEqualArray(int[] arrA, int[] arrB) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
{
    if (arrA.Length != arrB.Length) return false;
    else
    {
        for (int i = 0; i < arrA.Length; i++)
        {
            if (arrA[i] != arrB[i]) return false;
        }
    }
    return true;
}

void PrintArray(int[] arr, string preStr = "", string postStr = "/n") // Выводит на экран элементы массива
{
    Console.Write(preStr);
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.Write(postStr);
}

Console.Clear();

{   // Тест 1 (прямой)
    int n = 7;
    int[] expectedResult = { 0, 1, 1, 2, 3, 5, 8 };
    int[] actualResult = FillArrayFibonacci(n);

    Console.WriteLine("Тест 1 (прямой)");
    Console.Write($"Первые {n} чисел Фиббоначи: ");
    PrintArray(actualResult, postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2 (прямой)
    int n = 20;
    int[] expectedResult = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 };
    int[] actualResult = FillArrayFibonacci(n);

    Console.WriteLine("Тест 2 (прямой)");
    Console.Write($"Первые {n} чисел Фиббоначи: ");
    PrintArray(actualResult, postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}
{   // Тест 3 (пограничный)
    int n = 1;
    int[] expectedResult = { 0 };
    int[] actualResult = FillArrayFibonacci(n);

    Console.WriteLine("Тест 3 (пограничный)");
    Console.Write($"Первые {n} чисел Фиббоначи: ");
    PrintArray(actualResult, postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}