// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] GetArrWithOppositeEvenElement(int[,] arr) // Возращает массив в котором четные элементы заменены на противоположные
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] % 2 == 0) resultArr[i, j] = -arr[i, j];
            else                    resultArr[i, j] = arr[i, j];
    return resultArr;
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
    int[,] expectedResult = { { 1, -2, 3, -4 }, { 5, -6, 7, -8 }, { 9, -10, 11, -12 } };
    int[,] actualResult = GetArrWithOppositeEvenElement(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { 1, -2, 3, 4, 5 }, { 6, 7, -8, 9, 10 } };
    int[,] expectedResult = { { 1, 2, 3, -4, 5 }, { -6, 7, 8, 9, -10 } };
    int[,] actualResult = GetArrWithOppositeEvenElement(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[,] tstArr = { { 1 }, { -2 }, { 0 }, { 4 }, { 5 } };
    int[,] expectedResult = { { 1 }, { 2 }, { 0 }, { -4 }, { 5 } };
    int[,] actualResult = GetArrWithOppositeEvenElement(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int n = 4;
    int m = 3;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    int[,] actualResult = GetArrWithOppositeEvenElement(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "После замены: \n", postStr: "");
}