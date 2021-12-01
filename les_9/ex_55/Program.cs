// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

double[] GetColumnsAverage(int[,] arr) // Возращает сумму элкментов главной диагонали двухмерного массива, если массив не квадратный то возращает NULL
{
    double[] result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++) result[i] += arr[j, i];
        result[i] /= arr.GetLength(0);
    }
    return result;
}

void PrintNumberToGivenLength(int number, int givenLength) // Выводит число number на givenLength символов добавляя перед числом пробелы если необходимо
{
    int spacesLength = givenLength - number.ToString().Length;
    for (int i = 0; i < spacesLength; i++) Console.Write(" ");
    Console.Write(number);
}

int FindMaxElementLengthInArr(int[,] arr) // Находит сколько максимально символов занимает число в двухмерном массве
{
    int maxLength = arr[0, 0].ToString().Length;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int elementLength = arr[i, j].ToString().Length;
            if (maxLength < elementLength) maxLength = elementLength;
        }
    return maxLength;
}

void PrintArray(int[,] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы двумерного массива
{
    int elementLength = FindMaxElementLengthInArr(arr) + 1;
    Console.Write(preStr);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            PrintNumberToGivenLength(arr[i, j], elementLength);
        Console.WriteLine();
    }
    Console.Write(postStr);
}

void PrintDoubleArray(double[] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы массива double
{
    Console.Write(preStr);
    for (int i = 0; i < arr.GetLength(0); i++)
        Console.Write($"{arr[i]} ");
    Console.Write(postStr);
}

void FillRandomArray(int[,] arr, int minVal, int maxVal) // Возращает заполненный псевдослучайными числами [minVal;maxVal) двумерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(minVal, maxVal);
}

bool IsEqualDouble(double a, double b, double e = 0.0001) // Сравнивает два double: True - идентичны, False - отличаются.
{
    return Math.Abs(a - b) < e;
}

bool IsEqualArray(double[] arrA, double[] arrB) // Сравнивает поэлементно два одномерных double массива: True - идентичны, False - отличаются.
{
    if (arrA.Length != arrB.Length) return false;
    else
    {
        for (int i = 0; i < arrA.Length; i++)
                if (!IsEqualDouble(arrA[i], arrB[i])) return false;
    }
    return true;
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    double[] actualResult = GetColumnsAverage(tstArr);
    double[] expectedResult = { 5, 6, 7, 8 };
    PrintDoubleArray(actualResult, preStr: "Cреднее арифметическое каждого из столбцов: ", postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}.\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { -1, 2 }, { -3, -4 }, { 5, -6 } };
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    double[] actualResult = GetColumnsAverage(tstArr);
    double[] expectedResult = { 0.33333, -2.66666 };
    PrintDoubleArray(actualResult, preStr: "Cреднее арифметическое каждого из столбцов: ", postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}.\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[,] tstArr = { { -1, -2, -1, -2 }, { -1, -2, -1, -2 }, { -1, -2, -1, -2 }, { -1, -2, -1, -2 } };
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    double[] actualResult = GetColumnsAverage(tstArr);
    double[] expectedResult = { -1, -2, -1, -2 };
    PrintDoubleArray(actualResult, preStr: "Cреднее арифметическое каждого из столбцов: ", postStr: "\n");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}.\n");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int n = 5;
    int m = 2;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintDoubleArray(GetColumnsAverage(tstArr), preStr: "Cреднее арифметическое каждого из столбцов: ", postStr: "");
}