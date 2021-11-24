// 48. Показать двумерный массив размером m×n заполненный целыми числами

void PrintVarToLength(int var, int length) // Выводит число var на len символов добавляя перед числом пробелы если необходимо
{
    int spacesLength = length - var.ToString().Length;
    for (int i = 0; i < spacesLength; i++) Console.Write(" ");
    Console.Write(var);
}

int FindMaxVarLengthInArr(int[,] arr) // Находит сколько максимально символов занимает число в двухмерном массве
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

void PrintArray(int[,] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы двумерного массива
{
    int stringLength = FindMaxVarLengthInArr(arr) + 1;
    Console.Write(preStr);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            PrintVarToLength(arr[i, j], stringLength);
        Console.WriteLine();
    }
    Console.Write(postStr);
}

int[,] FillRandomArray(int[,] arr, int minVal, int maxVal) // Возращает заполненный псевдослучайными числами [minVal;maxVal) двумерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(minVal, maxVal);
    return arr;
}

int[,] CreateAndFillRandomArray(int m, int n, int minVal, int maxVal) // Возращает заполненный псевдослучайными числами [minVal;maxVal) двумерный массив
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(minVal, maxVal);
    return arr;
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] tstArr = { { 1, -2, 3, 4 }, { -5, 6, 7, 8 }, { 9, 10, -11, 12 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { 1, -2000 }, { -3, 4 }, { 500, 6 }, { -7, 800 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[,] tstArr = { { 1 }, { -2 }, { 300 }, { -4 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int[,] tstArr = { { 10000, -2, 3, -4 } };
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 5
    int n = 5;
    int m = 7;
    Console.WriteLine("Тест 5");
    int[,] tstArr = FillRandomArray(new int[m, n], -100, 101); // создаем массив, передаем его в метод, затем в ссылку массива tstArr записываем ссылку на область возращаемую методом
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 6
    int n = 4;
    int m = 3;
    Console.WriteLine("Тест 6");
    int[,] tstArr = new int[m, n]; // Создаем массив
    FillRandomArray(tstArr, -100, 101); // Передаем ссылку на массив и в указанной области заполняет массив
    PrintArray(tstArr, preStr: "Массив: \n");
}

{   // Тест 7
    int n = 4;
    int m = 3;
    Console.WriteLine("Тест 7");
    int[,] tstArr = CreateAndFillRandomArray(m, n, -100, 101); // Создает и заполняет массив и передает на него ссылку?
    PrintArray(tstArr, preStr: "Массив: \n");
}