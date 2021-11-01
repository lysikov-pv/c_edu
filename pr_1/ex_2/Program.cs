// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные

void RandomFill(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = new Random().Next(min, max);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintGreat(int[] array, int min)
{
    for (int i = 0; i < array.Length; ++i)
    {
        if(array[i]>min){
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
}

float Average(int[] array)
{
    float sum = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        sum += array[i];
    }
    return sum / array.Length;
}

int[] arrayA = new int[10];
RandomFill(arrayA, 10, 100);
Console.Write("A = ");
Print(arrayA);

int lastIndex = 0;

// 1  нарушают порядок возрастания
int[] arrayB1 = new int[10];
lastIndex = 0;
arrayB1[0] = arrayA[0];
for (int i = 1; i < arrayA.Length; ++i)
{
 if(arrayA[i]>arrayB1[lastIndex])
 {
     lastIndex++;
     arrayB1[lastIndex]=arrayA[i];
 }
}
Console.Write("1. B1 = ");
PrintGreat(arrayB1, 0);

// 2  больше среднего арифметического элементов A
int[] arrayB2 = new int[10];
lastIndex = 0;
float average = Average(arrayA);
Console.Write("2. average = " + average + "; B2 = ");
for (int i = 0; i < arrayA.Length; ++i)
{
 if(arrayA[i]>average)
 {
     lastIndex++;
     arrayB2[lastIndex]=arrayA[i];
 }
}
PrintGreat(arrayB2, 0);

// 3  четные
int[] arrayB3 = new int[10];
lastIndex = 0;
for (int i = 0; i < arrayA.Length; ++i)
{
 if(arrayA[i]%2==0)
 {
     lastIndex++;
     arrayB3[lastIndex]=arrayA[i];
 }
}
Console.Write("3. B3 = ");
PrintGreat(arrayB3, 0);