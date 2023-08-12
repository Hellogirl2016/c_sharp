// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine( "Insert, please, number of the day of the week" );
int num = Convert.ToInt32(System.Console.ReadLine( ));

if (num < 0 || num > 7)
   Console.WriteLine($" {num} is not  a  day of the week, type number 1-7. Thank you!");

else if (num == 6 || num == 7)
     Console.WriteLine($"Yes, day {num} is a weekend");

else    
    Console.WriteLine($"No, day {num} is NOT a weekend");
