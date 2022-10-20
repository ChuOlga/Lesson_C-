//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecNumber(int number)
{
  int sec = number / 10 % 10;

  number = sec;
  return sec;
}
Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecNumber(num);
Console.WriteLine($"New version of a number {num} is {result}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
bool ThirdDigitPresent(int num)
{
if(num > 99)
{
  return true;
}
else
{
  return false;
}
}

int GetThirdDigit(int num)
{
 while(num > 999)
  {
  num = num / 10;
  }

  return num = num % 10;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigitPresent(num))
{
  int result = GetThirdDigit(num);
  
  Console.WriteLine(result);
}

  else
  { 
  Console.WriteLine("No third digit");
  }
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekends(int num)
{
  if(num == 6)
  {
    return true;
  }
  if(num == 7)
  {
  return true;
  }
  else
  {
    return false;
  }
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Weekends(num);
Console.WriteLine(result);
*/