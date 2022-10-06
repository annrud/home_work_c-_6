Console.Clear();
Console.WriteLine("Программа переводит числа из десятичной " +
                  "системы в двоичную.");
Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("В двоичной системе число выглядит так: ");
ConvertNumber(number);
Console.WriteLine();	

void ConvertNumber(int numb)
{
    if (numb / 2 == 1 || numb / 2 == 0)
	{
		if (numb > 1)
		{
			Console.Write(numb / 2);
		}	
		Console.Write(numb % 2);	
	}
	else
	{
		ConvertNumber(numb / 2);
		Console.Write(numb % 2);
	}
} 
            