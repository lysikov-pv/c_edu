// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillArray(int[,] arr) // Возращает заполненный по правилу: Aₘₙ = m+n
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = i + j;
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
    int[,] actualResult = new int[3, 4];
    FillArray(actualResult);
    int[,] expectedResult = { { 0, 1, 2, 3 }, { 1, 2, 3, 4 }, { 2, 3, 4, 5 } };
    PrintArray(actualResult, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] actualResult = new int[5, 1];
    FillArray(actualResult);
    int[,] expectedResult = { { 0 }, { 1 }, { 2 }, { 3 }, { 4 } };
    PrintArray(actualResult, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}");
}