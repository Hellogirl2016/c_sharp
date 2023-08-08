// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine( "Insert, please,  positive number" );
int num1 = Convert.ToInt32(System.Console.ReadLine( ));
int digit = num1 % 2;
int count = 1;

if (digit == 0)
     Console.WriteLine($"{num1} is even number and all even numbers between 1 to {num1} : ");
             while (count * 2 < num1)
             {
                Console.WriteLine($"{count * 2}  ");
                count = count + 1;
             };
 
if  (digit > 0)  
        Console.WriteLine($"{num1} is NOT even number and here are all even numbers between 1 to {num1} ");
              while (count * 2 < num1)
              {
                 Console.WriteLine($"{count * 2}  ");
                 count = count + 1;
              };




