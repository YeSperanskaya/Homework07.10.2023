// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double LookingMeaningX (double k1, double b1, double k2, double b2)
{
    double differenceK1K2 = k2 - k1;
    double differenceB2B1 = b1 - b2;
    double x = differenceB2B1 / differenceK1K2;
    return x;
}
double LookingMeaningY(double k, double b, double x)
{
    return k * x + b;    
}


Console.WriteLine("Введите число k1 ");
double kK1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b1 ");
double bB1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число k2 ");
double kK2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b2 ");
double bB2 = Convert.ToDouble(Console.ReadLine());

if(bB1 == bB2 && kK1 == kK2)
{
    Console.WriteLine("Прямые накладываются друг на друга");
    return;
}
double xX = LookingMeaningX(kK1, bB1, kK2, bB2);

double yY1 = LookingMeaningY(kK1, bB1, xX);
double yY2 = LookingMeaningY(kK2, bB2, xX);
Console.WriteLine($"b1 = {bB1}, k1 = {kK1}, b2 = {bB2}, k2 = {kK2} -> ");

if (yY1 == yY2) 
{
    Console.Write($"({xX}, {yY1})");
} 
else 
{
    Console.Write($"Прямые не пересекаются {xX}, {yY1}, {yY2}");
}



