//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

int EvenCount (int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
      if (array[i] % 2 == 0)
        count += 1;
        return count;
}
Console.WriteLine("Введите размер массив:");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, 100, 999);
ShowArray(myArray);
int count = EvenCount(myArray);
Console.WriteLine($"Количество четных чисел в массиве " + count);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

int OddPosCount (int[] array)
{
  int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        sum += array[i];
        return sum;
}
Console.WriteLine("Введите размер массива:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число:" );
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимльное число:" );
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int sum = OddPosCount(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях " + sum);
*/

// решить Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray (int size)
{
    double[]array = new double[size];
    for(int i = 0; i < size; i++)
       array[i] = new Random(). NextDouble();
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(Math.Round (array [i], 2) + " ");
    Console.WriteLine();
}
double MaxMinDiff(double [] array)
{
  double maxValue = array [0];
  double minValue = array [0];
  
    for(int i = 1; i < array.Length; i++)
    {
        if (array [i] > maxValue) 
          maxValue = array [i];
          
          else if (array [i] < minValue)
          minValue = array [i];
    }
    return maxValue - minValue;
}

Console.WriteLine("Введите размер массива:" );
int n = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(n);
ShowArray(myArray);
double diff = MaxMinDiff(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом " + Math.Round (diff, 2 ));
*/
