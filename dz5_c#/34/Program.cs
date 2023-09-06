// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] arr)
{
for (int i=0; i<arr.Length; i++)
arr[i]= new Random().Next(100, 1000);
};

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
    System.Console.Write("]");
};

int CheckArray(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        int num = arr[i] % 2;
        if (num == 0)
        {count = count + 1;}
    }
return count;
}

int[] array = new int[6];
FillArray(array);
PrintArray(array);
CheckArray(array);
System.Console.WriteLine();
System.Console.WriteLine(CheckArray(array));

