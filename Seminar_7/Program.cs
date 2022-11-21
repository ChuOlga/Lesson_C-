//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            array[i,j] = new Random().NextDouble();
        }
    }
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(Math.Round (array [i,j], 1) + " ");
            }
    Console.WriteLine();
    }
}
Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue+1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void ElementValue(int[,] array, int m1, int n1)
{
    if (m1 < array.GetLength(0) && n1 < array.GetLength(1))
        Console.WriteLine("Element value " + array[m1, n1]);
    else
        Console.WriteLine("No element ");
}
Console.WriteLine("Input a number of rows in the array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns in the array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possppble value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the element of rows: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the of columns: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
ElementValue(myArray, m1, n1);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
            }
    Console.WriteLine();
    }
}
void ColumnAverage(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
    double sum = 0;
    
        for(int i = 0; i< array.GetLength(0); i++)
        {
        sum += array[i, j]; 
        }
    sum = sum / array.GetLength(0);
    
     Console.Write(Math.Round (sum, 1) + " ");
    }
}
Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);

Show2dArray(myArray);
Console.WriteLine ("Average: ");
ColumnAverage(myArray);
*/


