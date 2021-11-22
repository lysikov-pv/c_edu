// 47. Написать программу копирования массива

int[] CopyArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        result[i] = arr[i];
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

{   // Тест 1
    int[] initArr = { 0, 1, 2, 3, 4, 5, 6 };
    int[] expectedArr = { 0, 1, 2, 3, 4, 5, 6 };
    int[] actualArr = CopyArray(initArr);

    Console.WriteLine("Тест 1");
    PrintArray(initArr, preStr: "Исходный массив: ", postStr: "\n");
    PrintArray(actualArr, preStr: "Скопированный массив: ", postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualArr, expectedArr)}\n");

    // Тест 2 - меняем исходный массив и посмотрим что скопированный массив останется прежним
    initArr[2] = -2;
    initArr[5] = -5;

    Console.WriteLine("Тест 2");
    PrintArray(initArr, preStr: "Изменили исходный массив: ", postStr: "\n");
    PrintArray(actualArr, preStr: "Скопированный массив не изменился: ", postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(initArr, actualArr) != true}\n");


}