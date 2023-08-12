// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine( "Insert, please,  3-digit number" );
int num = Convert.ToInt32(System.Console.ReadLine( ));
int digit_2 = num / 10 % 10;
if (num > 999 || num < 100)
Console.WriteLine($" {num} is not  a  3-digit number, please, type a number 100-999. Thank you!");
else 
 Console.WriteLine($"{digit_2} is second number and of {num}");
          




