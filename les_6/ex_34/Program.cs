// 34. Написать программу замену элементов массива на противоположные

int[] GetOppositeArray(int[] arr) // Заменяет элементы массива на противоположные
{
    int[] result = arr;
    for (int i = 0; i < result.Length; i++)
        result[i] *= -1;
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
    int[] tstResultArr = { -1, 2, -3, -4, 5 };
    int[] methResultArr = GetOppositeArray(tstArr);
    PrintArray(tstArr, preStr: "Массив: ");
    PrintArray(methResultArr, preStr: "После замены: ");
    Console.WriteLine($"Результат верен: {IsEqualArray(methResultArr, tstResultArr)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[] tstArr = { -1, -2, -3, -4, -5 };
    int[] tstResultArr = { 1, 2, 3, 4, 5 };
    int[] methResultArr = GetOppositeArray(tstArr);
    PrintArray(tstArr, preStr: "Массив: ");
    PrintArray(methResultArr, preStr: "После замены: ");
    Console.WriteLine($"Результат верен: {IsEqualArray(methResultArr, tstResultArr)}\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[] tstArr = { 1, 2, 3, 4, 5 };
    int[] tstResultArr = { -1, -2, -3, -4, -5 };
    int[] methResultArr = GetOppositeArray(tstArr);
    PrintArray(tstArr, preStr: "Массив: ");
    PrintArray(methResultArr, preStr: "После замены: ");
    Console.WriteLine($"Результат верен: {IsEqualArray(methResultArr, tstResultArr)}\n");
}