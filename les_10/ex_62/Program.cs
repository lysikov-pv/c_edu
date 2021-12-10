// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[] FindIndexOfMin(int[,] arr) // Возращает индекс минимального элемента
{
    int[] index = { 0, 0 };
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] < arr[index[0], index[1]])
            {
                index[0] = i;
                index[1] = j;
            }
    return index;
}

int[,] DeleteRow(int[,] arr, int row) // Возращает новый массив копию передаваемого без строки
{
    int[,] resultArr = new int[arr.GetLength(0) - 1, arr.GetLength(1)]; // Хотим не изменить а получить новую матрицу
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i < row) resultArr[i, j] = arr[i, j];
            else if (i > row) resultArr[i - 1, j] = arr[i, j];
    return resultArr;
}

int[,] DeleteColumn(int[,] arr, int column) // Возращает новый массив копию передаваемого без столбца
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1) - 1]; // Хотим не изменить а получить новую матрицу
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (j < column) resultArr[i, j] = arr[i, j];
            else if (j > column) resultArr[i, j - 1] = arr[i, j];
    return resultArr;
}

int[,] DeleteRowAndColumn(int[,] arr, int row, int column) // Возращает новый массив копию передаваемого без строки и столбца
{
    int[,] arrWithoutRow = DeleteRow(arr, row);
    int[,] resultArr = DeleteColumn(arrWithoutRow, column);
    return resultArr;
}

int[,] DeleteMinWithRowAndColumn(int[,] arr) // Возращает новый массив копию передаваемого без строки и столбца в которой находится минимум
{
    int[] index = FindIndexOfMin(arr);
    int[,] resultArr = DeleteRowAndColumn(arr, row: index[0], column: index[1]);
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
    int[,] tstArr = { { -1, 2, 1, 3 }, { 2, 5, 1, 3 }, { 4, 3, 1, 6 } };
    int[,] expectedResult = { { 5, 1, 3 }, { 3, 1, 6 } };
    int[,] actualResult = DeleteMinWithRowAndColumn(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После удаления минимума с колонкой и столбцом : \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { -1, 2, 1, 3 }, { 2, -5, 1, 3 }, { 4, 3, 1, 6 } };
    int[,] expectedResult = { { -1, 1, 3 }, { 4, 1, 6 } };
    int[,] actualResult = DeleteMinWithRowAndColumn(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После удаления минимума с колонкой и столбцом : \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int n = 5;
    int m = 6;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    int[,] actualResult = DeleteMinWithRowAndColumn(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После удаления минимума с колонкой и столбцом : \n", postStr: "");
}