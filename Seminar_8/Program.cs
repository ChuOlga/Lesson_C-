// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minvalue, int maxvalue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue + 1);
    }
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
void SortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int l = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = l;
                }
            }
        }
    }

}

Console.WriteLine("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine();
SortDescending(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minvalue, int maxvalue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue + 1);
    }
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
int [,] RowsSum (int[,] array)
{
    int[,] sumArray = new int[array.GetLength(0), 1];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j< array.GetLength(1); j++)
        {
        sum += array[i,j]; 
        }
        sumArray[i,0]= sum;
    }
    return sumArray;
}
int MinSum (int[,] array)
{
    int min = array[0,0];
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i,0])
            {
                min = array[i,0];
                pos = i;
            }
    }
    return pos;
}
Console.WriteLine("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, x, max);
Show2dArray(myArray);

int[,] sumArray = RowsSum(myArray);
Console.WriteLine($"Row with the minimum sum: {MinSum(sumArray) + 1}");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
void ProductMatrix(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Different size matrices!");
        return;
    }
    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    array[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    Show2dArray(array);
}
Console.WriteLine("Input a number of rows first: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns first : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value first: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value first: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Input a number of rows second: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns second: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value second: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value second: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("First matrix:");
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine("Second matrix:");
int[,] myArray2 = CreateRandom2dArray(m1, n1, min1, max1);
Show2dArray(myArray2);
Console.WriteLine("Product of two matrices:");
ProductMatrix(myArray, myArray2);
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

bool IsPresent(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
                else if (array[i, j, k] == 0)  return false;           

            }
        }
    }
    return false;
}
int[,,] CreateRandom3dArray(int v1, int v2, int v3)
{
    int[,,] array = new int[v1, v2, v3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int temp = new Random().Next(10,100);

                while (IsPresent(array, temp))
                {
                    temp = new Random().Next(10,100);
                } 
                array[i,j,k] = temp;
            }
        }
    }
    return array;
}
void Show3dArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]} ({i}, {j}, {k}); ");
      }
      Console.WriteLine();
    }
  }
}
Console.WriteLine("Imput first array parameter: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput second array parameter: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput third array parameter: ");
int p = Convert.ToInt32(Console.ReadLine());

if((m*n*p) > 99) Console.WriteLine("It is not possible to create an array with non-repeating numbers");
else
{
    int [,,] myArray = CreateRandom3dArray(m, n, p);
    Show3dArray(myArray);
}
