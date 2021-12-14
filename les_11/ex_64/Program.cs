// 64. Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.

int[,] GetPascalTriangle(int size) // Заполняет массив как треугольник Паскаля
{
    int[,] array = new int[size, size + 1];
    array[0, 1] = 1;
    for (int i = 1; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1); j++)
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j ];
    return array;
}

void PrintSpaces(int size) // Выводит заданное количество пробелов
{
    for (int i = 0; i < size; i++) Console.Write(" ");
}

void PrintTriangleArray(int[,] arr) // Выводит на экран элементы двумерного массива
{
    int spaces = arr.GetLength(0) * 2; // Магические числа для табуляции
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        PrintSpaces(spaces);
        spaces -= 2;  // Магические числа для табуляции
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] != 0) Console.Write(String.Format("{0,4:0}", arr[i, j]));
                else Console.Write("     ");
            }
        Console.WriteLine();
    }
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[,] triangle = GetPascalTriangle(size:1);
    PrintTriangleArray(triangle);
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[,] triangle = GetPascalTriangle(size:2);
    PrintTriangleArray(triangle);
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[,] triangle = GetPascalTriangle(size:6);
    PrintTriangleArray(triangle);
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int[,] triangle = GetPascalTriangle(size:13);
    PrintTriangleArray(triangle);
}