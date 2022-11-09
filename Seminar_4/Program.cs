//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Pow (int A, int B)
{
  int result = 1;
  for (int current = 0; current < B; current++)
  {
  result *= A;
  }
  return result;
}

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {Pow(A,B)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int FindSum(int number)
{
  int sum = 0;
  while(number > 0)
  {
     sum = sum + number % 10;
     number = number / 10;
  }
  return sum;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {FindSum(a)}");
*/
