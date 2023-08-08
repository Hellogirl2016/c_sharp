// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine( "Insert, please,  number" );
int num1 = Convert.ToInt32(System.Console.ReadLine( ));
int digit = num1 % 2;

if (digit == 0)
    Console.WriteLine($"{num1} is even number");
else
    Console.WriteLine($"{num1} is NOT even number");
