// 42. Определить сколько чисел больше 0 введено с клавиатуры

int[] StrToArray(string str) // Переводит строку из чисел разделенных пробелом в числовой массив
{
    string[] strArr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int[] arr = new int[strArr.Length];
    for (int i = 0; i < strArr.Length; i++)
    {
        arr[i] = int.Parse(strArr[i]);
    }
    return arr;
}

int CountPosInArr(int[] arr) // Считает кол-во элементов в массиве больших нуля
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

Console.Clear();

{   // Тест 1 (прямой)
    string tstStr = "1 -2 3 -4 5";
    int expectedResult = 3;
    int actualResult = CountPosInArr(StrToArray(tstStr));

    Console.WriteLine("Тест 1 (прямой)");
    Console.WriteLine($"Последовательность с клавиатуры: {tstStr}");
    Console.WriteLine($"Количество элементов больше нуля: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{   // Тест 2 (прямой)
    string tstStr = "0 0 3 -4 -5 6 -7 -8";
    int expectedResult = 2;
    int actualResult = CountPosInArr(StrToArray(tstStr));

    Console.WriteLine("Тест 2 (прямой)");
    Console.WriteLine($"Последовательность с клавиатуры: {tstStr}");
    Console.WriteLine($"Количество элементов больше нуля: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{
   // Тест 3 (пограничный)
    string tstStr = "-1 -2 -3 -4 -5";
    int expectedResult = 0;
    int actualResult = CountPosInArr(StrToArray(tstStr));

    Console.WriteLine("Тест 3 (пограничный)");
    Console.WriteLine($"Последовательность с клавиатуры: {tstStr}");
    Console.WriteLine($"Количество элементов больше нуля: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}

{
   // Тест 4 (пограничный)
    string tstStr = "0 0 5";
    int expectedResult = 1;
    int actualResult = CountPosInArr(StrToArray(tstStr));

    Console.WriteLine("Тест 4 (пограничный)");
    Console.WriteLine($"Последовательность с клавиатуры: {tstStr}");
    Console.WriteLine($"Количество элементов больше нуля: {actualResult}. Результат верен: {actualResult == expectedResult}\n");
}