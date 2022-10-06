Console.Clear();
Console.WriteLine("Программа находит точку пересечения двух прямых, " +
                  "заданных уравнениями y = k1*x + b1, y = k2*x + b2");
Console.Write("Введите значение b1: ");
double B1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double K1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double B2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double K2 = double.Parse(Console.ReadLine()!);

(double, double) dot = FindDot(B1, K1, B2, K2);
Console.WriteLine($"Точка пересечения: ({dot.Item1}; {dot.Item2})");


(double, double) FindDot(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * b2 - k2 * b1) / (k1 - k2);
    return (x, y);
} 
             