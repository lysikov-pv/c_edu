// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить

int?[,] TransposeArray(int?[,] arr) // Возращает новый массив в котором строки заменены на столбцы
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        int?[,] resultArr = new int?[arr.GetLength(0), arr.GetLength(0)]; // Хотим не изменить а получить новую матрицу;
        for (int i = 0; i < resultArr.GetLength(0); i++)
            for (int j = i; j < resultArr.GetLength(0); j++)
            {
                resultArr[i, j] = arr[j, i];
                resultArr[j, i] = arr[i, j];
            }
        return resultArr;
    }
    else
    {
        int?[,] resultArr = { { null } };
        return resultArr;
    }
}

void PrintArray(int?[,] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы двумерного массива
{
    Console.Write(preStr);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,5:0}", arr[i, j]));
        Console.WriteLine();
    }
    Console.Write(postStr);
}

void FillRandomArray(int?[,] arr, int minVal, int maxVal) // Возращает заполненный псевдослучайными числами [minVal;maxVal) двумерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(minVal, maxVal);
}

bool IsEqualArray(int?[,] arrA, int?[,] arrB) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
{
    if (arrA.GetLength(0) != arrB.GetLength(0) || arrA.GetLength(1) != arrB.GetLength(1)) return false;
    else
    {
        for (int i = 0; i < arrA.GetLength(0); i++)
            for (int j = 0; j < arrA.GetLength(1); j++)
                if (arrA[i, j] != arrB[i, j]) return false;
    }
    return true;
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int?[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
    int?[,] expectedResult = { { 1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 15 }, { 4, 8, 12, 16 } };
    int?[,] actualResult = TransposeArray(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    if (actualResult[0, 0] != null)
        PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    else
        Console.WriteLine("Замена не возможна!");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int?[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    int?[,] expectedResult = { { null } };
    int?[,] actualResult = TransposeArray(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    if (actualResult[0, 0] != null)
        PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    else
        Console.WriteLine("Замена не возможна!");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int n = 5;
    int m = 5;
    int?[,] tstArr = new int?[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    int?[,] actualResult = TransposeArray(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
        if (actualResult[0, 0] != null)
        PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    else
        Console.WriteLine("Замена не возможна!");
}