// Найти разницу между min и max элементами массива
Console.WriteLine("Задайте количество элементов одномерного массива");
int count = Convert.ToInt32(Console.ReadLine());
double[] number = new double[count];
FillArray(number, 0, 999);
PrintArray(number);
double max = MaxNumbers(number);
double min = MinNumbers(number);
Console.WriteLine($"Сумма max= {max} сумма min= {min}");
Console.WriteLine($"Разница этих значений= {max-min}");
void FillArray(double[] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        Console.WriteLine();
    }
}

double MaxNumbers(double[] array)
{
    double temp = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (temp < array[i])
            temp = array[i];
    }
    return temp;
}

double MinNumbers(double[] array)
{
    double temp = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (temp > array[i])
            temp = array[i];
    }
    return temp;
}