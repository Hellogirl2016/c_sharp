// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[] LineData1 = new double[2];
LineData1[0] = 2;
LineData1[1] = 4;
double[] LineData2 = new double[2];
LineData2[0] = 0;
LineData2[1] = 3;

double[] FindCoord(double [] LineData1, double [] LineData2){
    double [] coord = new double[2];
    coord[0] = (LineData1[1]-LineData2[1])/(LineData2[0]-LineData1[0]);
    coord[1] = LineData1[1]*coord[0]+LineData1[1];
    System.Console.WriteLine(coord[0]);
    System.Console.WriteLine(coord[1]);
    return coord;
}

FindCoord(LineData1, LineData2);
