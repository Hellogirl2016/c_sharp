// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine( "Insert, please, first number" );
int num1 = Convert.ToInt32(System.Console.ReadLine( ));
System.Console.WriteLine( "Insert, please, second number" );
int num2 = Convert.ToInt32(System.Console.ReadLine( ));
System.Console.WriteLine( "Insert, please, third number" );
int num3 = Convert.ToInt32(System.Console.ReadLine( ));


int max = num1;

if (num2 > max)
max = num2;
if  (num3 > max)
 max = num3;
Console.WriteLine($"Maximal number between {num1}, {num2} and {num3} is {max}");
