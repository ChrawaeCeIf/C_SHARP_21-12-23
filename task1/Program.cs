// 1. Напишите программу, которая на вход принимает два числа и проверяет является второе число квадратом второго.

Console.Write("Enter A Number 1");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter A Number 2");
int b2 = int.Parse(Console.ReadLine()!);
if (b1 * b1 == b2) 
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
