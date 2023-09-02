// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int a, int b)
{
int res = 1;
for (int i = 1; i <= b; i++)
{
    res = res * a;
}
return res;
}


System.Console.WriteLine("Vvedite osnovanie chisla (A)");
int A = Convert.ToInt32(System.Console.ReadLine( ));
System.Console.WriteLine("Vvedite stepen' chisla (B)");
int B = Convert.ToInt32(System.Console.ReadLine( ));
System.Console.WriteLine($"{Stepen(A, B)}");