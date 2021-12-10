// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] CopyArray(int[,] arr) // Возращает новый массив копию передаваемого
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)]; // Хотим не изменить а получить новую матрицу
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            resultArr[i, j] = arr[i, j];
    return resultArr;
}

int[,] GetSortByRow(int[,] arr) // Возращает новый массив в котором элементы, каждой строки упорядочены
{
    int[,] resultArr = CopyArray(arr);
    for (int i = 0; i < resultArr.GetLength(0); i++)
        for (int j = 0; j < resultArr.GetLength(1) - 1; j++)
        {
            int indexMax = j;
            for (int k = j + 1; k < resultArr.GetLength(1); k++)
            {
                if (resultArr[i, k] > resultArr[i, indexMax]) indexMax = k;
            }
            int temp = resultArr[i, j];
            resultArr[i, j] = resultArr[i, indexMax];
            resultArr[i, indexMax] = temp;
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
    int[,] expectedResult = { { 4, 3, 2, 1 }, { 8, 7, 6, 5 }, { 12, 11, 10, 9 } };
    int[,] actualResult = GetSortByRow(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { 1, 2, 2 }, { -4, 5, 6 }, { 7, -8, 9 }, { 10, 11, -12 } };
    int[,] expectedResult = { { 2, 2, 1 }, { 6, 5, -4 }, { 9, 7, -8 }, { 11, 10, -12 } };
    int[,] actualResult = GetSortByRow(tstArr);
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
    int[,] actualResult = GetSortByRow(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
}