// Семинар 2: работа с массивами и функциями

int Perimetr(int a, int b) // Вычисляет периметр прямоугольника со сторонами a и b
{
    return (2 * (a + b));
}
int Max2(int a, int b) // Возвращает максимальное из двух чисел
{
    if (a > b) return a; else return b;
}
int Max3(int a, int b, int c) // Возвращает максимальное из трех чисел
{
    if (a > b)
    {
        if (a > c) return a; else return c;
    }
    else
    {
        if (b > c) return b; else return c;
    }
}
int[] CreateArray(int n) // Возвращает массив длинной n заполненный числами из диапазона [0;100]
{
    int[] a = new int[n];
    for (int i = 0; i < a.Length; ++i) a[i] = new Random().Next(0, 101);
    return a;
}
void PrintArray(int[] a) // Выводит массив
{
    for (int i = 0; i < a.Length; ++i) Console.Write(a[i] + " ");
    Console.WriteLine();
}
int[] clearArray(int[] array) // Обнуляет массив
{
    for (int i=0; i < array.Length; ++i) array[i] = 0;
    return array;
}

// Обявление и вывод массива
// int[] array = new int[4] { 1, 2, 3, 4 };
// for (int i = 0; i < 4; ++i) Console.WriteLine(array[i]);


// Заполнение массива вводом с клавиатуры
// for (int i = 0; i < 3; ++i)
// {
//     string s = Console.ReadLine();
//     array[i] = Convert.ToInt32(s);
// }


// Заполненнить и вывести массива arr
// int[] arr = new int[10];
// Random rnd = new Random();
// for (int i = 0; i < 9; ++i) arr[i] = rnd.Next(0, 100);
// for (int i = 0; i < 9; ++i) Console.Write(arr[i] + " ");
// Console.WriteLine();

// Написать функцию сравнения трех чисел
// int a = 3;
// int b = 4;
// Console.WriteLine(Max3(a, b, 10));


// Создать и вывести массив
int[] arr = CreateArray(10);
PrintArray(arr);


// Вывести произведение четных элементы массива не заканчивающиеся на 0
long res = 1;
for (int i = 0; i < arr.Length; ++i)
    if (arr[i] % 2 == 0 && arr[i] % 10 != 0)
        res = res * arr[i];
Console.Write(res);