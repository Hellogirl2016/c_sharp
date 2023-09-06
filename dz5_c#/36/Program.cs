// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] arr)
{
for (int i=0; i<arr.Length; i++)
arr[i]= new Random().Next(-99, 100);
};

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
    System.Console.Write("]");
};

int SumArray(int[] arr)
{
    int sum = 0;
    for (int i=1; i<arr.Length; i=i+2)
    {
        sum = sum + arr[i];  
    }
 return sum;
}

int[] array = new int[6];
FillArray(array);
PrintArray(array);
SumArray(array);
System.Console.WriteLine();
System.Console.WriteLine(SumArray(array));