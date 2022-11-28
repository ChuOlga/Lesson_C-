// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNaturNum(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNaturNum(n - 1);
}
Console.WriteLine("Imput a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNaturNum(n);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNaturNum(int m, int n)
{
    if (m < n)
        return SumNaturNum(m + 1, n) + m;
    if (m > n)
        return SumNaturNum(m, n + 1) + n;
    return m;
}
Console.WriteLine("Input a natural number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a natural number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers: {SumNaturNum(m, n)}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m >0) && (n == 0)) return Ackermann(m - 1, 1);
        else return Ackermann(m - 1, Ackermann(m, n - 1));  
}
Console.WriteLine("Input a natural number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a natural number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ackerman function({m}, {n}) = {Ackermann(m, n)}");
*/