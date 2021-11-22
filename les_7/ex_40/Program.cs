// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double GetArrayMax(double[] arr) // Возращает максимальный элемент массива
{
    double result = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] > result) result = arr[i];
    return result;
}

double GetArrayMin(double[] arr) // Возращает минимальный элемент массива
{
    double result = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] < result) result = arr[i];
    return result;
}

void PrintArray(double[] arr, string preStr = "", string postStr = "/n") // Выводит на экран элементы массива
{
    Console.Write(preStr);
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.Write(postStr);
}

Console.Clear();

{   // Тест 1 (прямой)
    double[] arr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
    double expectedResult = 4.4;
    double actualResult = GetArrayMax(arr) - GetArrayMin(arr);

    Console.WriteLine("Тест 1 (прямой)");
    PrintArray(arr, preStr: "Массив: ", postStr: "\n");
    Console.WriteLine($"Разница между максимальным и минимальным эл-ом: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2 (прямой)
    double[] arr = { 2.2, 1.1, 3.3, 6, 5.5 }; // Не крайние элементы, одно из чисел целое
    double expectedResult = 4.9;
    double actualResult = GetArrayMax(arr) - GetArrayMin(arr);
    
    Console.WriteLine("Тест 2 (прямой)");
    PrintArray(arr, preStr: "Массив: ", postStr: "\n");
    Console.WriteLine($"Разница между максимальным и минимальным эл-ом: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 3 (пограничный)
    double[] arr = { 1.1, -2.2, 3.3, 4, -5.5 }; // Одно из чисел целое, минимум отрицательный
    double expectedResult = 9.5;
    double actualResult = GetArrayMax(arr) - GetArrayMin(arr);
    
    Console.WriteLine("Тест 3 (пограничный)");
    PrintArray(arr, preStr: "Массив: ", postStr: "\n");
    Console.WriteLine($"Разница между максимальным и минимальным эл-ом: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 4 (пограничный)
    double[] arr = { -1.1, -2.2, -3.3, -4.4, -5.5 }; // Оба отрицательные
    double expectedResult = 4.4;
    double actualResult = GetArrayMax(arr) - GetArrayMin(arr);
    
    Console.WriteLine("Тест 4 (пограничный)");
    PrintArray(arr, preStr: "Массив: ", postStr: "\n");
    Console.WriteLine($"Разница между максимальным и минимальным эл-ом: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 5 (обратный)
    double[] arr = { -1.1, -2.2, -3.3, -4.4, -5.5 };
    double notExpectedResult = -6.6; // Не получаем сумму
    double actualResult = GetArrayMax(arr) - GetArrayMin(arr);
    
    Console.WriteLine("Тест 5 (обратный)");
    PrintArray(arr, preStr: "Массив: ", postStr: "\n");
    Console.WriteLine($"Разница между максимальным и минимальным эл-ом: {actualResult}. Результат верен: {actualResult != notExpectedResult}\n");
}

{   // Тест 6 (обратный)
    double[] arr = { 1.1, -2.2, -3.3, -4.4, -5.5 };
    double notExpectedResult = -6.6; // Максимум это минимальное положительное, правильный знак разницы
    double actualResult = GetArrayMax(arr) - GetArrayMin(arr);
    
    Console.WriteLine("Тест 6 (обратный)");
    PrintArray(arr, preStr: "Массив: ", postStr: "\n");
    Console.WriteLine($"Разница между максимальным и минимальным эл-ом: {actualResult}. Результат верен: {actualResult != notExpectedResult}\n");
}