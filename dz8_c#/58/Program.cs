// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Matrix multiplyting");
Console.WriteLine("Type the  number in the 1 row, 1 column of the 1 matrix");
int first = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 1 row, 2 column of the 1 matrix");
int second = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 1 column of the 1 matrix");
int third = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 2 column of the 1 matrix");
int forth = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 1 row, 1 column of the 2 matrix");
int fifth = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 1 row, 2 column of the 2 matrix");
int sixth = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 1 column of the 2 matrix");
int seventh = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 2 column of the 2 matrix");
int eighth = Convert.ToInt32(System.Console.ReadLine( ));

 int firstNew = (first*fifth+second*seventh);
 int secondNew = (first*sixth+second*eighth);
 int thirdNew = (third*fifth+forth*seventh);
 int forthNew = (third*sixth+forth*eighth);
 Console.WriteLine("Matrix multiplyting result:");
 System.Console.WriteLine($"{firstNew} {secondNew}");
 System.Console.WriteLine($"{thirdNew} {forthNew}");




