
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] newMatrix = new int[n, m];
    int currentValue = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            newMatrix[i, j] = currentValue;
            currentValue += k;
        }
    }
    return newMatrix;
}

// public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
// {  
//     int [] number={0,-1};
//     if ((rowPosition-1) > 0 && (rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1) > 0 && (columnPosition-1)<=matrix.GetLength(1) )
//     {
//         number[1]=0;
//         number[0]=matrix[rowPosition-1,columnPosition-1];
//         return number;
//     }
//     return number;
// }

// public static void PrintCheckIfError (int[] results, int X, int Y)
// {
//     if (results[1]==-1){Console.WriteLine("There is no such index");}
//     else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//     }
// }


double[] FindAverageInColumns(int[,] matrix)
{
    
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
     { double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        result[j] = sum/matrix.GetLength(0);
        
    }
    return result;
}
void PrintListAvr(double[] list)
    {
      System.Console.WriteLine("The averages in columns are: ");
      for (int i = 0; i < list.Length; i++)
      {
            Console.Write("{0:0.00 }", list[i]) ;
            System.Console.Write("\t");
        }
        
    }
     

// + "\t"}")
    

int[,] result = CreateIncreasingMatrix(3, 4, 4);
PrintArray(result);
double[] list = FindAverageInColumns(result);
PrintListAvr(list);

// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1);j++)
//             {
//                 Console.Write($"{matrix[i,j]}"+"\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] newMatrix = new int[n,m];
//         int currentValue = 1;
//         for (int i=0; i<n; i++)
//         {
//             for (int j=0; j<m; j++)
//             {
//                 newMatrix[i,j] = currentValue;
//                 currentValue += k;
//             }
//         }
//         return newMatrix;
//     }

//     static void PrintListAvr (double [] list)
//     {
//         Console.WriteLine("The averages in columns are: ");
//         foreach (double el in list)
//         {
//             Console.Write($"{el:f2}"+"\t");

//         }
//         Console.WriteLine();
//     }

//     static double [] FindAverageInColumns (int [,] matrix)
//     { 
//         double runningSum=0;
//         double [] columns = new double [matrix.GetLength(1)];
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             runningSum=0;
//             for (int i=0; i<matrix.GetLength(0);i++)
//             {
//                 runningSum=runningSum+matrix[i,j];
//             }
//             columns[j]=runningSum/matrix.GetLength(0);
//         }
//         return columns;
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k;

//         if (args.Length >= 3) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintListAvr(FindAverageInColumns(result));
//     }
