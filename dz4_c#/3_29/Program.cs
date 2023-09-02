// Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.
void Creation(int[] arr)
{
for (int i=0; i<arr.Length; i++)
arr[i]= new Random().Next(1, 51);
};

void Printing(int[] arr)
{
    System.Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    System.Console.Write($"{arr[i]} ");
    System.Console.Write("]");
};

int[] array = new int[8];
Creation(array);
Printing(array);
