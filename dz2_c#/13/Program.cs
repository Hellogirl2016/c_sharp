// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine( "Insert, please, number" );
int num = Convert.ToInt32(System.Console.ReadLine( ));
int num1 = num;
int count = 0;
if (num1 / 100 == 0)
     Console.WriteLine($"{num} does not have the third number");

  while (num1 > 0)
  {
     
     num1 = (num1 / 10);
     count = count + 1;
  };
Console.WriteLine($" {count} digits in this number {num}");
          
for (int i = 0; i < count-3; i++)
      {
         num = num / 10;
      };

int digit3 = num % 10;
Console.WriteLine($" {digit3} is the third digit in this number ");
