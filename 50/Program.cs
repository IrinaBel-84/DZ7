// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] CreateArray(int a, int b)
{
    double[,] array = new double[a, b];
    return array;
}
double[,] array = CreateArray(10, 10);
double[,] FillArrayRandom(double[,] coll)
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

double[,] PrintArr(double[,] array)
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
FillArrayRandom(array);


Console.WriteLine("введите строку на которой искомый элемент ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите столбец на которой искомый элемент ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= array.GetLength(0) & m>0 & n <= array.GetLength(1) & n>0)
{
    Console.WriteLine($"{array[m - 1, n - 1]}");
}
else Console.WriteLine("такого числа в массиве нет");

PrintArr(array);














