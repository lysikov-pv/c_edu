// 48. Показать двумерный массив размером m×n заполненный целыми числами

void PrintNumberToGivenLength(double number, int givenLength) // Выводит число number на givenLength символов добавляя перед числом пробелы если необходимо
{
    int spacesLength = givenLength - number.ToString().Length;
    for (int i = 0; i < spacesLength; i++) Console.Write(" ");
    Console.Write(number);
}

int FindMaxVarLengthInArr(double[,] arr) // Находит сколько максимально символов занимает число в двухмерном массве
{
    int maxLen = arr[0, 0].ToString().Length;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int curLen = arr[i, j].ToString().Length;
            if (maxLen < curLen) maxLen = curLen;
        }
    return maxLen;
}

void PrintArray(double[,] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы двумерного массива
{
    int stringLength = FindMaxVarLengthInArr(arr) + 1;
    Console.Write(preStr);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            PrintNumberToGivenLength(arr[i, j], stringLength);
        Console.WriteLine();
    }
    Console.Write(postStr);
}

// int CountNumbersAfterDot(string number) // Считает количество чисел после запятой
// {
//     var dotPosition = number.LastIndexOf(".", StringComparison.Ordinal);
//     if (dotPosition == -1) return 0;
//     else                   return number.Length - dotPosition - 1;
// }

double GetRandomDouble(int minVal, int maxVal, int numbersAfterDot) // Корявая функция которая возращает вещественное число в [minVal, maxVal) с количеством чисел после запятой numbersAfterDot
{
    double degree = Math.Pow(10, numbersAfterDot);    
    return new Random().Next(Convert.ToInt32(minVal * degree), Convert.ToInt32(maxVal * degree)) / degree;
}

void FillRandomArray(double[,] arr, int minVal, int maxVal, int numbersAfterDot) // Возращает заполненный псевдослучайными числами [minVal;maxVal) двумерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = GetRandomDouble(minVal, maxVal, numbersAfterDot);
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    double[,] tstArr = { { 1.11, -2.2222, 3.3, 4.444 }, { -5.55, 6.6, 7.777, 8.88 }, { 9.999, 10.10, -11.111, 12.12 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    double[,] tstArr = { { 1.111, -2000 }, { -3.3, 4.444 }, { 500, 6.66 }, { -7.77, 800 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    double[,] tstArr = { { 1.1111 }, { -2.22 }, { 300 }, { -4.44444 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    double[,] tstArr = { { 10000, -2.222, 3.3, -4.44 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 5
    int n = 5;
    int m = 7;
    Console.WriteLine("Тест 5");
    double[,] tstArr = new double[m, n];
    FillRandomArray(tstArr, minVal: -100, maxVal: 101, numbersAfterDot: 2);
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 6
    int n = 4;
    int m = 3;
    Console.WriteLine("Тест 6");
    double[,] tstArr = new double[m, n];
    FillRandomArray(tstArr, minVal: 0, maxVal: 101, numbersAfterDot: 5);
    PrintArray(tstArr, preStr: "Массив: \n");
}