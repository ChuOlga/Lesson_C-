//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindprome(int num)
{
  int first = num % 10;
  int second = num / 10 % 10;
  int fourth = num / 1000 % 10;
  int fifth = num / 10000;

if(first == fifth && second == fourth)
{
  return true;
}
else
{
  return false;
}
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result=Palindprome(num);
Console.WriteLine(result);
*/

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
  double x = x2 - x1;
  double y = y2 - y1;
  double z = z2 - z1;
  double dist = Math.Sqrt(x*x + y*y + z*z);
  return dist;
}
Console.WriteLine("Введите координаты первой точки по оси х: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси у: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси z: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси х: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси у: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси z: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, z1, x2, y2, z2);
result = Math.Round(result,2);
Console.WriteLine($"Расстояние между точками {result}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int num)
{
  int n = 1;
  while(n <= num)
  {
    Console.Write(n * n * n  + " ");
    n++;
  }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/

