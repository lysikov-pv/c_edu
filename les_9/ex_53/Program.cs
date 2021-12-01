// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[] FindIndex(int[,] arr, int findElement) // Возращает индекс найденного элемента в формате массива {i, j} если значение не найдено то возращает {-1 ,-1} 
{
    int[] resultIndexArr = { -1, -1 };
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == findElement)
            {
                resultIndexArr[0] = i;
                resultIndexArr[1] = j;
            }
    return resultIndexArr;
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

bool IsEqualArray(int[] arrA, int[] arrB) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
{
    if (arrA.Length != arrB.Length) return false;
    else
    {
        for (int i = 0; i < arrA.Length; i++)
                if (arrA[i] != arrB[i]) return false;
    }
    return true;
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    int findElement = 7;
    int[] expectedResult = {1, 2};
    int[] actualResult = FindIndex(tstArr, findElement);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Индекс значения '{findElement}': ({actualResult[0]}, {actualResult[1]}). Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 11 }, { 9, 10, 11, 12 } }; // Два вхождения 11
    int findElement = 11;
    int[] expectedResult = {2, 2}; // Ожидаем последнее вхождение
    int[] actualResult = FindIndex(tstArr, findElement);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Индекс значения '{findElement}': ({actualResult[0]}, {actualResult[1]}). Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    int findElement = 99;
    int[] expectedResult = {-1, -1};
    int[] actualResult = FindIndex(tstArr, findElement);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Индекс значения '{findElement}': ({actualResult[0]}, {actualResult[1]}). Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}