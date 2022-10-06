Console.Clear();
Console.Write("Введите число M - количество чисел, которые нужно ввести: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите через ENTER {M} чисел:");
int count = FindCountAboveZero(M);
Console.WriteLine($"Количество чесел больше нуля: {count}");


int FindCountAboveZero(int numbers, int i = 0, int cnt = 0)
{
    if (i == numbers)
    {
        return cnt;
    }
    else
    {
        double number = double.Parse(Console.ReadLine()!);
        if (number > 0)
            cnt++;
        return FindCountAboveZero(numbers, ++i, cnt);
    }
}
