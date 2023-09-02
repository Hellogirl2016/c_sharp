// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Length(int num)
{
int i = 0;
for (i = 0; num > 0; i++)
{
    num = num/10;
}
return i;
};

int Summa(int num, int dlina)
{
int sum = 0;
for (int i = 1; i <= dlina; i++)
{
sum = sum + num % 10;
num = num/10;
}
return sum;
};

Console.WriteLine("Vvedite tseloe chislo");
int num = Convert.ToInt32(Console.ReadLine());
int dlina = Length(num);
Console.Write($"Sum of all numbers is {Summa(num, dlina)}");
