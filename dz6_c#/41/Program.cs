// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Printing(int[] arr)
{
    System.Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
    System.Console.Write("]");
};

int Check(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    if (arr[i]>0)
    count ++;
    return count;
}

System.Console.WriteLine("Vvedite 4 chisla");
int[] arr = new int[4];

for (int i = 0; i < 4; i++){
int num=Convert.ToInt32(System.Console.ReadLine( ));
arr[i]=num;
}

Printing(arr);
Check(arr);
System.Console.WriteLine();
System.Console.WriteLine(Check(arr));