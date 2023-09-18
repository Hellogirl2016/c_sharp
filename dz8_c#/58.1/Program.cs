// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[] matrixOne = new int[8];
Console.WriteLine("Matrix multiplyting");
Console.WriteLine("Type the  number in the 1 row, 1 column of the 1 matrix");
matrixOne[0] = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 1 row, 2 column of the 1 matrix");
matrixOne[1] = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 1 column of the 1 matrix");
matrixOne[2] = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 2 column of the 1 matrix");
matrixOne[3] = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 1 row, 1 column of the 2 matrix");
matrixOne[4] = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 1 row, 2 column of the 2 matrix");
matrixOne[5] = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 1 column of the 2 matrix");
matrixOne[6] = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine("Type the number in the 2 row, 2 column of the 2 matrix");
matrixOne[7] = Convert.ToInt32(System.Console.ReadLine( ));

System.Console.WriteLine("Original matrixes are:");
System.Console.WriteLine($"{matrixOne[0]}  {matrixOne[1]}"+" \t " +  $"{matrixOne[4]}  {matrixOne[5]}");
System.Console.WriteLine($"{matrixOne[2]}  {matrixOne[3]}"+" \t " +  $"{matrixOne[6]}  {matrixOne[7]}");

int[] matrixResult = new int[4];
matrixResult[0] = (matrixOne[0]*matrixOne[4]+matrixOne[1]*matrixOne[6]);
matrixResult[1] = (matrixOne[0]*matrixOne[5]+matrixOne[1]*matrixOne[7]);
matrixResult[2] = (matrixOne[2]*matrixOne[4]+matrixOne[3]*matrixOne[6]);
matrixResult[3] = (matrixOne[2]*matrixOne[5]+matrixOne[3]*matrixOne[7]);

System.Console.WriteLine("The result of multiplying is:");
System.Console.WriteLine($"{matrixResult[0]}  {matrixResult[1]}");
System.Console.WriteLine($"{matrixResult[2]}  {matrixResult[3]}");

