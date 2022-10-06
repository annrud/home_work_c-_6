Console.Clear();
Console.WriteLine("Программа принимает на вход положительные " +
                  "числа и считает среднее значение этих чисел.");
Console.WriteLine("Введите числа через ENTER " +
              "(для завершения ввода введите -1): ");
double mean = FindMean();
Console.Write("Среднее значение: ");
Console.WriteLine(mean);


double FindMean(int i = 0, int cnt = 0, double sum = 0)
{
    double number = double.Parse(Console.ReadLine()!);
    if (number == -1)
    {
        return sum/cnt;
    }
    else
    {
        return FindMean(++i, ++cnt, sum += number);
    }
}
              