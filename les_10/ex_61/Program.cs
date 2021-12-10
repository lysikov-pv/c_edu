// 61. Найти произведение двух матриц

int?[,] MultiplyArrays(int?[,] firstArray, int?[,] secondArray) // Возращает новый массив произведение первого и второго либо масиив {{null}}
{
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        int?[,] resultArr = new int?[firstArray.GetLength(0), secondArray.GetLength(1)];
        for (int i = 0; i < resultArr.GetLength(0); i++)
            for (int j = 0; j < resultArr.GetLength(1); j++)
            {
                resultArr[i, j] = 0;
                for (int k = 0; k < firstArray.GetLength(1); k++)
                    resultArr[i, j] += firstArray[i, k] * secondArray[k, j];
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

bool IsEqualArray(int?[,] firstArray, int?[,] seconArray) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
{
    if (firstArray.GetLength(0) != seconArray.GetLength(0) || firstArray.GetLength(1) != seconArray.GetLength(1)) return false;
    else
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
            for (int j = 0; j < firstArray.GetLength(1); j++)
                if (firstArray[i, j] != seconArray[i, j]) return false;
    }
    return true;
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int?[,] firstArray = { { 2, 0, -1 }, { 0, -2, 2 } };
    int?[,] secondArray = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };
    int?[,] expectedResult = { { 8, 1, 0 }, { -6, -2, -2 } };
    int?[,] actualResult = MultiplyArrays(firstArray, secondArray);
    PrintArray(firstArray, preStr: "Массив A: \n", postStr: "");
    PrintArray(secondArray, preStr: "Массив B: \n", postStr: "");
    if (actualResult[0, 0] != null)
        PrintArray(actualResult, preStr: "Произведение AB: \n", postStr: "");
    else
        Console.WriteLine("Произведение не возможно!");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int?[,] firstArray = { { 2, 1, 1 }, { 3, 0, 1 } };
    int?[,] secondArray = { { 3, 1 }, { 2, 1 }, { 1, 0 } };
    int?[,] expectedResult = { { 9, 3 }, { 10, 3 } };
    int?[,] actualResult = MultiplyArrays(firstArray, secondArray);
    PrintArray(firstArray, preStr: "Массив A: \n", postStr: "");
    PrintArray(secondArray, preStr: "Массив B: \n", postStr: "");
    if (actualResult[0, 0] != null)
        PrintArray(actualResult, preStr: "Произведение AB: \n", postStr: "");
    else
        Console.WriteLine("Произведение не возможно!");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int?[,] firstArray = { { 2, 1, 1 }, { 3, 0, 1 } };
    int?[,] secondArray = { { 3, 1 }, { 2, 1 } };
    int?[,] expectedResult = { { null } };
    int?[,] actualResult = MultiplyArrays(firstArray, secondArray);
    PrintArray(firstArray, preStr: "Массив A: \n", postStr: "");
    PrintArray(secondArray, preStr: "Массив B: \n", postStr: "");
    if (actualResult[0, 0] != null)
        PrintArray(actualResult, preStr: "Произведение AB: \n", postStr: "");
    else
        Console.WriteLine("Произведение не возможно!");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}