// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


void FillArray(double[] arr)
{
for (int i=0; i<arr.Length; i++)
{
double a =  new Random().NextDouble();
arr[i]= -99.99 + (a*199.98);
}

};

void PrintArray(double[] arr)
{
    System.Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    Console.Write("{0:0.00 }", arr[i]); 
    System.Console.Write("]");
};

double MinArray(double[] arr)
{
    double min = 100;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i] < min)
        {min = arr[i];}
    }
 return min;
}

double MaxArray(double[] arr)
{
    double max = -100;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i] > max)
        {max = arr[i];}
    }
 return max;
}

double[] array = new double[6];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
MinArray(array);
MaxArray(array);
System.Console.Write("max "); Console.Write("{0:0.00 }, ", MaxArray(array)); 
System.Console.Write("min "); Console.Write("{0:0.00 }, ", MinArray(array)); 
System.Console.Write("difference "); Console.Write("{0:0.00 }", MaxArray(array)-MinArray(array)); 



