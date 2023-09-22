﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n) 
{ 
    if (n < m) 
        return 0; 
    return n+Sum(m,n - 1); 
} 
 
System.Console.WriteLine("Enter please bottom number, m "); 
int m = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Enter please upper number, n "); 
int n = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Sum of all numbers from m to n: ");
 
System.Console.WriteLine(Sum(m, n));