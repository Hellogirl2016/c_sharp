
// 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j]}" + "\t");
        System.Console.WriteLine("  ");
    }
}

int[] SumR(int[,] array)
    {   
        int[] sumResult = new int [array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow = sumRow + array[i, j];
        
    }
    // System.Console.WriteLine($"{sumRow}");
    sumResult[i] = sumRow;

}
return sumResult;
    }

void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            System.Console.Write($"{array[i]}" + "\t");
        System.Console.WriteLine("  ");
    }
}
void Sorting(int[] array)
{
    int min=1000;
    int index=-1;
    for (int i = 0; i < array.Length; i++)
   {
      if (min > array[i]) 
      {min = array[i];
      index = i;}
    
   }
 System.Console.WriteLine($"Mininal sum of elements {min} in row {index+1}");
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
SumR(array);
int[] sumResult = SumR(array);
PrintArray1(sumResult);
Sorting(sumResult);