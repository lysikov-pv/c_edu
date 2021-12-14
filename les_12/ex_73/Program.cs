// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

void Printsequence(int first, int second, int n)
{
    if (n < 1) return;
    int nextNumber = first + second;
    Console.Write($"{nextNumber} ");
    Printsequence(first: second, second: nextNumber, n: n - 1);
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int first = 2;
    int second = 5;
    int n = 10;
    Console.Write($"{first} {second} ");
    Printsequence(first, second, n);
}

{   // Тест 1
    Console.WriteLine("\n\nТест 2");
    int first = 1;
    int second = 2;
    int n = 20;
    Console.Write($"{first} {second} ");
    Printsequence(first, second, n);
}