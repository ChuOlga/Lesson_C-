//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input ferst number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);  
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input ferst number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input thid number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if(a > b)
{
    max = a;
}
else
{
    max = b;
}
if(max < c)
{
    max = c;
}
Console.WriteLine(max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a%2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
} 
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;
while(current <=N)
{
    Console.Write(current + " ");
    current +=2;
}
*/