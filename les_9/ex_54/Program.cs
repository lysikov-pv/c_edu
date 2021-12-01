// 54. В матрице чисел найти сумму элементов главной/побочной диагонали

string GetSumElementsOfMainDiag(int[,] arr) // Возращает сумму элкментов главной диагонали двухмерного массива, если массив не квадратный то возращает NULL
{
    if(arr.GetLength(0) != arr.GetLength(1)) return "NULL";
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        sum += arr[i, i];
    return sum.ToString();
}

string GetSumElementsOfSideDiag(int[,] arr) // Возращает сумму элкментов побочной диагонали двухмерного массива, если массив не квадратный то возращает NULL
{
    if(arr.GetLength(0) != arr.GetLength(1)) return "NULL";
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        sum += arr[arr.GetLength(0) - i - 1, i];
    return sum.ToString();
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

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, {13, 14, 15, 16}};
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    // Сумма элементов главной диагонали
    string actualResult = GetSumElementsOfMainDiag(tstArr);
    string expectedResult = "34";
    Console.WriteLine($"Сумма элементов главной диагонали: {actualResult}. Результат верен: {actualResult == expectedResult}.");
    // Сумма элементов побочной диагонали
    actualResult = GetSumElementsOfSideDiag(tstArr);
    expectedResult = "34";
    Console.WriteLine($"Сумма элементов побочной диагонали: {actualResult}. Результат верен: {actualResult == expectedResult}.\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { -1, 2, 3 }, { -4, -5, 6 }, { 7, -8, -9 } };
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    // Сумма элементов главной диагонали
    string actualResult = GetSumElementsOfMainDiag(tstArr);
    string expectedResult = "-15";
    Console.WriteLine($"Сумма элементов главной диагонали: {actualResult}. Результат верен: {actualResult == expectedResult}.");
    // Сумма элементов побочной диагонали
    actualResult = GetSumElementsOfSideDiag(tstArr);
    expectedResult = "5";
    Console.WriteLine($"Сумма элементов побочной диагонали: {actualResult}. Результат верен: {actualResult == expectedResult}.\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[,] tstArr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }};
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    // Сумма элементов главной диагонали
    string actualResult = GetSumElementsOfMainDiag(tstArr);
    string expectedResult = "NULL";
    Console.WriteLine($"Сумма элементов главной диагонали: {actualResult}. Результат верен: {actualResult == expectedResult}.");
    // Сумма элементов побочной диагонали
    actualResult = GetSumElementsOfSideDiag(tstArr);
    expectedResult = "NULL";
    Console.WriteLine($"Сумма элементов побочной диагонали: {actualResult}. Результат верен: {actualResult == expectedResult}.\n");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int n = 6;
    int m = 6;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    Console.WriteLine($"Сумма элементов главной диагонали: {GetSumElementsOfMainDiag(tstArr)}.");
    Console.WriteLine($"Сумма элементов побочной диагонали: {GetSumElementsOfSideDiag(tstArr)}.");
}