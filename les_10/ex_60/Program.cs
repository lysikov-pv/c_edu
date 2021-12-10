// 60. Составить частотный словарь элементов двумерного массива

int GetFreq(int[,] arr, int value) // Возращает количество вхождения элемента в двухмерный массив
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == value) count++;
    return count;
}

int[] GetDictionary(int[,] arr) // Возращает словарь элементов двумерного массива в виде одномерного массива
{
    int[] tmpArr = new int[arr.GetLength(0) * arr.GetLength(1)]; // Максимальное кол-во элементов в словаре это количество эл-ов входного массива на случай если все элементы разные
    tmpArr[0] = arr[0, 0]; // Т.к. массив tmpArr по умолчанию заполнен 0, то первый элемент записываем вручную
    int tmpArrLength = 1; // И, говорим что в частотном словаре уже есть 1 элемент
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < tmpArrLength; k++)
            {
                if (arr[i, j] == tmpArr[k]) break; // Если элемент уже есть в словаре, то остальные не смотрим
                else if (k == tmpArrLength - 1) // Иначе если дошли до конца словаря, то добавляем число в конец словаря
                {
                    tmpArrLength++;
                    tmpArr[tmpArrLength - 1] = arr[i, j];
                }
            }
        }
    int[] resultArr = new int[tmpArrLength]; // Создаем выходной массив длиной в количество уникальных элементов 
    for (int i = 0; i < tmpArrLength; i++) // Переносим временный массив в результирующий
        resultArr[i] = tmpArr[i];
    return resultArr;
}

int[,] GetFreqDictionary(int[,] arr) // Возращает частотный словарь элементов двумерного массива в виде двухмерного массива: 1-ая строка - уникальные элементы, 2-ая строка количество повторений
{
    int[] dictionary = GetDictionary(arr); // Получем словарь уникальных элементов
    int[,] freqDictionary = new int[2, dictionary.Length]; // Создаем двухмерный частотный словарь 
    for (int i = 0; i < dictionary.Length; i++)
    {
        freqDictionary[0, i] = dictionary[i]; // В первую строку пишем уникальный элемент
        freqDictionary[1, i] = GetFreq(arr, dictionary[i]); // Во вторую частоту его вхождения
    }
    return freqDictionary;
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
    int[,] expectedResult = { { -1, 2, 1, 3, 5, 4, 6 }, { 1, 2, 3, 3, 1, 1, 1 } };
    int[,] actualResult = GetFreqDictionary(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "Частотный словарь: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] tstArr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int[,] expectedResult = { { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1 } };
    int[,] actualResult = GetFreqDictionary(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "Частотный словарь: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[,] tstArr = { { -1, -1, -1, -1 }, { -1, -1, -1, -1 } };
    int[,] expectedResult = { { -1 }, { 8 } };
    int[,] actualResult = GetFreqDictionary(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "Частотный словарь: \n", postStr: "");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int n = 3;
    int m = 5;
    int[,] tstArr = new int[m, n];
    FillRandomArray(tstArr, minVal: -10, maxVal: 11);
    int[,] actualResult = GetFreqDictionary(tstArr);
    PrintArray(tstArr, preStr: "Массив: \n", postStr: "");
    PrintArray(actualResult, preStr: "Частотный словарь: \n", postStr: "");
}