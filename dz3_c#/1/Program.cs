 void IsPalindrome(number, global::System.Int32 number)
 {
int num1 = number / 10000;
if (num1 > 0 && num1 < 10)
{
 int num2 = (number - num1 * 10000)/1000;
 int num3 = (number - num1 * 10000 - num2 * 1000)/100;
 int num4 = (number - num1 * 10000 - num2 * 1000 - num3 * 100)/10;
 int num5 = (number - num1 * 10000 - num2 * 1000 - num3 * 100 - num4*10);
 
if (num1 == num5 && num2 == num4)
{
Console.WriteLine(" True " );
}
  else 
  {
Console.WriteLine(" False ");
  }  
}

else 
{
Console.WriteLine($" {number} Число не пятизначное");
Console.WriteLine(" False ");
}

 }

 

Console.WriteLine(" insert 5 d m " );
int number = Convert.ToInt32(System.Console.ReadLine( ));
Console.WriteLine($" {number}");

void IsPalindrome(number);

using System;
// variant s saita
// public class Answer
// {
//     static bool IsPalindrome(int number){
//         if (number < 10000 || number >= 100000){
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }
//         return reverse == number;
//     }

//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 645464;
//         }

//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }