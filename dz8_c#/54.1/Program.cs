// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void FillArray(int[,] array)
{
for (int i=0; i<array.GetLength(0); i++){
    for (int j=0; j<array.GetLength(1); j++){
        array[i,j]= new Random().Next(1, 100);
    }
}
 
}

void PrintArray(int[,] array)
     {
        for (int i = 0; i< array.GetLength(0); i++)
        {
            for (int j = 0; j< array.GetLength(1); j++)
             System.Console.Write($"{array[i, j],3}" +"\t");
             System.Console.WriteLine("  ");}
     }


int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i+1 ; j < mas.Length; j++)
                {
                    if (mas[i] <  mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }                   
                }            
            }
            return mas;
        }
void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            System.Console.Write($"{array[i]} " );
            
    }
}

void Sort(int[,] array)
{ 
    int[] masTemp = new int[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            masTemp[j] = array[i,j];
        }
        
        BubbleSort(masTemp);
        // PrintArray1(masTemp);

        for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i,j] = masTemp[j];
         }
        // System.Console.WriteLine();
    }

}


int[,] array = new int[5,5];
FillArray(array);
PrintArray(array);
Sort(array);
System.Console.WriteLine();
PrintArray(array);

