// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int GetRowSum(int[,] arr, int row) // Возращает сумму строки
{
    int sum = arr[row, 0];
    for (int i = 0; i < arr.GetLength(1); i++) sum += arr[row, i];
    return sum;
}

int GetRowWithMinSum(int[,] arr) // Возращает индекс строки с минимально суммой
{
    int row = 0;
    int minSum = GetRowSum(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int currentRowSum = GetRowSum(arr, i);
        if ( currentRowSum < minSum)
        {
            minSum = currentRowSum;
            row = i;
        }
    }
    return row;
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

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    int expectedResult = 0;
    int actualResult = GetRowWithMinSum(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Строка с минимальной суммой: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { -1, -2, -3, -4 }, { -5, -6, -7, -8 }, { -9, -10, -11, -12 } };
    int expectedResult = 2;
    int actualResult = GetRowWithMinSum(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Строка с минимальной суммой: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int n = 2;
    int m = 5;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    int actualResult = GetRowWithMinSum(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Строка с минимальной суммой: {actualResult}.");
}

{   // Тест 4
    Console.WriteLine("Тест 3");
    int n = 4;
    int m = 2;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    int actualResult = GetRowWithMinSum(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Строка с минимальной суммой: {actualResult}.");
}