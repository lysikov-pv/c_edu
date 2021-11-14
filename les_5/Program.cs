// 23. Показать таблицу квадратов чисел от 1 до N
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру
// 31. Задать массив из 8 элементов и вывести их на экран
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int InputVar(string str) // Возращает значение введенное с клавиатуры
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int RandomVar(string str, int min, int max) // Возращает значение из диапазона [min;max) попутно выводя его на экран 
{
    int x = new Random().Next(min, max);
    Console.WriteLine(str + x);
    return x;
}

int ParsIntToArray(int x, int[] arr) // Заполняет массив цифрами из числа (1234 => {4,3,2,1}) и возращает длину полученного массива 
{
    int i = 0;
    while (x > 0)
    {
        arr[i] = x % 10;
        i++;
        x = x / 10;
    }
    return i;
}

int[] CreateArray(int n, int min, int max) // Возвращает массив длинной n заполненный числами из диапазона [min;max)
{
    int[] a = new int[n];
    for (int i = 0; i < a.Length; ++i) a[i] = new Random().Next(min, max);
    return a;
}
void PrintArray(int[] a) // Выводит массив
{
    for (int i = 0; i < a.Length; ++i) Console.Write($"{a[i]} ");
    Console.WriteLine();
}


int exampleNum;
do
{
    Console.Clear();
    Console.WriteLine("23. Показать таблицу квадратов чисел от 1 до N");
    Console.WriteLine("24. Найти кубы чисел от 1 до N");
    Console.WriteLine("25. Найти сумму чисел от 1 до А");
    Console.WriteLine("26. Возведите число А в натуральную степень B используя цикл");
    Console.WriteLine("27. Определить количество цифр в числе");
    Console.WriteLine("28. Подсчитать сумму цифр в числе");
    Console.WriteLine("29. Написать программу вычисления произведения чисел от 1 до N");
    Console.WriteLine("30. Показать кубы чисел, заканчивающихся на четную цифру");
    Console.WriteLine("31. Задать массив из 8 элементов и вывести их на экран");
    Console.WriteLine("32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
    Console.WriteLine("0.  Выход");
    exampleNum = InputVar("Введите номер задачи для проверки: ");
    switch (exampleNum)
    {
        case 23: // Показать таблицу квадратов чисел от 1 до N
            {
                int n = InputVar("N = ");
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i} x {i} = {i * i}");
                }
                break;
            }
        case 24: // Найти кубы чисел от 1 до N
            {
                int n = InputVar("N = ");
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i} x {i} x {i} = {i * i * i}");
                }
                break;
            }
        case 25: // Найти сумму чисел от 1 до А
            {
                int a = InputVar("A = ");
                int sum = 0;
                for (int i = 1; i <= a; i++) sum += i;
                Console.WriteLine($"Сумма чисел от 1 до {a} равна: {sum}");
                break;
            }
        case 26: // Возведите число А в натуральную степень B используя цикл
            {
                int a = InputVar("A = ");
                int b = InputVar("B = ");
                int result = a;
                for (int i = 1; i < b; i++) result *= a;
                Console.WriteLine($"{a} в степени {b}: {result}");
                break;
            }
        case 27: // Определить количество цифр в числе
            {
                int a = InputVar("A = ");
                int[] arr = new int[10];
                Console.WriteLine($"Количество цифр в числе: {ParsIntToArray(a, arr)}");
                break;
            }
        case 28: // Подсчитать сумму цифр в числе
            {
                int a = InputVar("A = ");
                int[] arr = new int[10];
                int arrLength = ParsIntToArray(a, arr);
                int sum = 0;
                for (int i = 0; i < arrLength; i++) sum += arr[i];
                Console.WriteLine($"Cумма цифр: {sum}");
                break;
            }
        case 29: // Написать программу вычисления произведения чисел от 1 до N
            {
                int n = InputVar("N = ");
                int result = 1;
                for (int i = 1; i <= n; i++) result *= i;
                Console.WriteLine($"Произведение чисел от 1 до {n} равно: {result}");
                break;
            }
        case 30: // Показать кубы чисел, заканчивающихся на четную цифру
            {
                int n = InputVar("Сколько кубов показать: ");
                int count = 0;
                int i = 2;
                while (count < n)
                {
                    count++;
                    Console.WriteLine($"{count}. {i * i * i}");
                    i += 2; // Куб четного всегда будет четным
                }
                break;
            }
        case 31: // Задать массив из 8 элементов и вывести их на экран
            {
                int[] arr = CreateArray(8, 0, 100);
                PrintArray(arr);
                break;
            }
        case 32: // Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
            {
                int[] arr = CreateArray(8, 0, 2);
                PrintArray(arr);
                break;
            }
    }
    if (exampleNum != 0) // Оставить решение задачи на экране пока не нажат Enter
    {
        Console.WriteLine("Нажмите Enter");
        Console.ReadLine();
    }
}
while (exampleNum != 0);
