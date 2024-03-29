﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ack (int m, int n) 
{ 
if (m==0) 
return n+1;
else if (n==0) 
return Ack (m-1,1);
else 
return Ack (m-1,Ack (m,n-1)); 
} 

System.Console.WriteLine("Enter please parameter m (> or = 0)"); 
int m = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Enter please parameter n (> or = 0) "); 
int n = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Ackermann function with m=" + $"{m}" + " and n=" + $"{n}" + ":"); 
System.Console.WriteLine(Ack (m, n));
