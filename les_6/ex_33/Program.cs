// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

int GetSumPosElement(int[] arr) // Находит сумму положительных элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0) sum += arr[i];
    return sum;
}
int GetSumNegElement(int[] arr) // Находит сумму отрицательных элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] < 0) sum += arr[i];
    return sum;
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
    Console.WriteLine("Тест 1");
    int[] tstArr = { 1, -2, 3, 4, -5 };
    int tstPosResult = 8;
    int tstNegResult = -7;
    PrintArray(tstArr, preStr: "Массив: ", postStr: "\n");
    int methPosResult = GetSumPosElement(tstArr);
    int methNegResult = GetSumNegElement(tstArr);
    Console.WriteLine($"Сумма положительных эл-в: {methPosResult}. Результат верен: {tstPosResult == methPosResult }");
    Console.WriteLine($"Сумма отрицательных эл-в: {methNegResult}. Результат верен: {tstNegResult == methNegResult }\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[] tstArr = { -1, -2, -3, -4, -5 };
    int tstPosResult = 0;
    int tstNegResult = -15;
    PrintArray(tstArr, preStr: "Массив: ", postStr: "\n");
    int methPosResult = GetSumPosElement(tstArr);
    int methNegResult = GetSumNegElement(tstArr);
    Console.WriteLine($"Сумма положительных эл-в: {methPosResult}. Результат верен: {tstPosResult == methPosResult }");
    Console.WriteLine($"Сумма отрицательных эл-в: {methNegResult}. Результат верен: {tstNegResult == methNegResult }\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[] tstArr = { 1, 2, 3, 4, 5, 6 };
    int tstPosResult = 21;
    int tstNegResult = 0;
    PrintArray(tstArr, preStr: "Массив: ", postStr: "\n");
    int methPosResult = GetSumPosElement(tstArr);
    int methNegResult = GetSumNegElement(tstArr);
    Console.WriteLine($"Сумма положительных эл-в: {methPosResult}. Результат верен: {tstPosResult == methPosResult }");
    Console.WriteLine($"Сумма отрицательных эл-в: {methNegResult}. Результат верен: {tstNegResult == methNegResult }\n");
}