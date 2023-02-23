// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
        }
    }
    return coll;
}

int[,] PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2}");
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine("введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(m, n);
FillArrayRandom(array);
PrintArr(array);

double a = 0;
double result = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    result = 0;
    a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        a = a + array[i, j];
    }
    result = Math.Round((a / m),2);
    Console.Write($"{result} ");
}
