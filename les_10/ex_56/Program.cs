﻿// 56. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] CopyArray(int[,] arr) // Возращает новый массив копию передаваемого
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)]; // Хотим не изменить а получить новую матрицу
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            resultArr[i, j] = arr[i, j];
    return resultArr;
}

int[,] SwapFirstAndLastRow(int[,] arr) // Возращает новый массив в котором элементы, первой и последней строки обменены
{
    int[,] resultArr = CopyArray(arr);
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        resultArr[0, i] = arr[arr.GetLength(0) - 1, i];
        resultArr[arr.GetLength(0) - 1, i] = arr[0, i];
    }
    return resultArr;
}

void PrintArray(int[,] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы двумерного массива
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

void FillRandomArray(int[,] arr, int minVal, int maxVal) // Возращает заполненный псевдослучайными числами [minVal;maxVal) двумерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(minVal, maxVal);
}

bool IsEqualArray(int[,] arrA, int[,] arrB) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
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
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    int[,] expectedResult = { { 9, 10, 11, 12 }, { 5, 6, 7, 8 }, { 1, 2, 3, 4 } };
    int[,] actualResult = SwapFirstAndLastRow(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { 1, 2, 3 }, { -4, 5, 6 }, { 7, -8, 9 }, { 10, 11, -12 } };
    int[,] expectedResult = { { 10, 11, -12 }, { -4, 5, 6 }, { 7, -8, 9 }, { 1, 2, 3 } };
    int[,] actualResult = SwapFirstAndLastRow(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int n = 5;
    int m = 6;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    int[,] actualResult = SwapFirstAndLastRow(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
}