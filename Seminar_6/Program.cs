//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateArray (int size)
{
    int[] array = new int[size];
    Console.WriteLine("Введите массив по одному числу за раз: ");
    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}
int PositiveCount (int[] array)
{
  int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        count +=1; 
    }
return count;
}
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(n);
int count = PositiveCount(myArray);
Console.WriteLine("Количество положительных чисел: " + count);
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void FindIntersection (double k1, double b1,double k2, double b2)
{
  double x = 0;
  double y = 0;
  if (k1 == k2) 
  {
    if (b1 == b2)
    Console.WriteLine("Прямые совпадают ");
    else 
    Console.WriteLine("Прямые параллельны ");
  }
  else 
  {
    y=(k1*b2-k2*b1)/(k1-k2);
    x=(b2-b1)/(k1-k2);
    Console.WriteLine("Точка пересечения: (" + Math.Round (x, 2) + ";" + Math.Round (y, 2) + ")");
  }
}
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
FindIntersection(k1, b1, k2, b2);
*/

