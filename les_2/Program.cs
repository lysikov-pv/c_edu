int Perimetr(int a, int b)
{
    return (2 * (a + b));
}
int Max2(int a, int b)
{
    if (a > b) return a; else return b;
}
int Max3(int a, int b, int c)
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
/*
int[] clearArray(int[] array)
{
    for(int i; i<3; ++i) array[i]=0;
    return array[];
}
*/
/*
int[] array = new int[4] { 1, 2, 3, 4 };
//for (int i = 0; i < 3; ++i) Console.WriteLine(array[i]);int a = 3;
int b = 4;
/*
for (int i = 0; i < 3; ++i)
{
    string s=Console.ReadLine();
    array[i]=Convert.ToInt32(s);
}
*/
/*
int[] a = new int[10];
Random rnd = new Random();
for(int i=0; i<9;++i) a[i]=rnd.Next(0,100);
for (int i = 0; i < 9; ++i) Console.Write(a[i]+" ");*/
//Console.WriteLine(Max3(a, b, 10));

int[] CreateArray(int n)
{
    int[] a = new int[n];
    for (int i = 0; i < a.Length; ++i) a[i] = new Random().Next(0, 101);
    return a;
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; ++i) Console.Write(a[i] + " ");
}

int[] arr = CreateArray(5);
PrintArray(arr);

long res = 1;
for (int i = 0; i < arr.Length; ++i)
    if (arr[i] % 2 == 0 && arr[i] % 10 != 0)
        res = res * arr[i];

Console.WriteLine();
Console.Write(res);
