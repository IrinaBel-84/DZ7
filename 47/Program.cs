// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

double [,]array = new double [m,n];

// double [,] CreateArray (int m, int n)
// {
//     double[,] array = new double [m,n];
//     return array;
// }

double [,] FillArrayRandom (double[,]coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll [i,j]= new Random().Next(-99, 100)/10.0;
        }
    }
    return coll;
}

double [,] PrintArr (double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 2}");
        }
        Console.WriteLine();
    }
    return array;
}


// double [,]array = CreateArray(m,n);
array = FillArrayRandom(array);
PrintArr (array);

























