// 35. Определить, присутствует ли в заданном массиве, некоторое число 

bool IsEnterInArray(int[] arr, int x) // Проверяет входит ли элемент в массив
{
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == x) return true;
    return false;
}

void PrintArray(int[] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы массива
{
    Console.Write(preStr);
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.Write(postStr);
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[] tstArr = { 1, -2, 3, 4, -5 };
    int x = 0;
    bool tstResult = false;
    bool methResult = IsEnterInArray(tstArr, x);
    PrintArray(tstArr, preStr: "Массив: ");
    Console.WriteLine($"Элемент {x} встречается в массиве: {methResult}. Результат верен: {methResult == tstResult}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[] tstArr = { 1, -2, 3, 4, -5 };
    int x = -5;
    bool tstResult = true;
    bool methResult = IsEnterInArray(tstArr, x);
    PrintArray(tstArr, preStr: "Массив: ");
    Console.WriteLine($"Элемент {x} встречается в массиве: {methResult}. Результат верен: {methResult == tstResult}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[] tstArr = { 1, -2, 3, 4, -5 };
    int x = 5;
    bool tstResult = false;
    bool methResult = IsEnterInArray(tstArr, x);
    PrintArray(tstArr, preStr: "Массив: ");
    Console.WriteLine($"Элемент {x} встречается в массиве: {methResult}. Результат верен: {methResult == tstResult}\n");
}