
        

 int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
       int[,] matrix = new int[n, m];
       int a = 1;
       for (int i = 0; i < n; i++) 
       {
       for (int j = 0; j < m; j++) 
        {
        matrix[i, j] = a;
        a = a + k;
      }
    }
    return matrix;
  }

 

  void PrintArray (int [,] matrix)
    {
      for (int i = 0; i< matrix.GetLength(0); i++)
        {
            for (int j = 0; j< matrix.GetLength(1); j++)
             System.Console.Write($"{matrix[i, j], 5} ");
               
            System.Console.WriteLine("      ");}


    }

    int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      int[] arr = new int[2];
       if (matrix.GetLength(0) > rowPosition && matrix.GetLength(1) > columnPosition )
       {
       
       arr[0] = matrix[rowPosition-1, columnPosition-1];
       arr[1] = 0;
       } 
       else 
       arr[0] = 0;
       arr[1] = 0;

       return arr;
    }
// void PrintArray1 (int [] matrix)
//     {
//       for (int i = 0; i< matrix.Length; i++)
//        System.Console.Write($"{matrix[i]} ");

//     }

    void PrintCheckIfError(int[] array, int x, int y)
    {
      if (array[0]==0)
      {System.Console.WriteLine("There is no such index");}
      else
      {System.Console.WriteLine($"The number in [{x}, {y}] is {array[0]}");}
}

int[,] result = CreateIncreasingMatrix(3, 4, 2); 
PrintArray(result);
int[] array = FindNumberByPosition (result,8,3);
// PrintArray1(array);
PrintCheckIfError(array, 2, 2);

    
//     using System;

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

//     public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
//     {  
//         int [] number={0,-1};
//         if ((rowPosition-1) > 0 && (rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1) > 0 && (columnPosition-1)<=matrix.GetLength(1) )
//         {
//             number[1]=0;
//             number[0]=matrix[rowPosition-1,columnPosition-1];
//             return number;
//         }
//         return number;
//     }

//     public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//         if (results[1]==-1){Console.WriteLine("There is no such index");}
//         else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k, x, y;

//         if (args.Length >= 5) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//            x = int.Parse(args[3]);
//            y = int.Parse(args[4]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//            x = 2;
//            y = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }