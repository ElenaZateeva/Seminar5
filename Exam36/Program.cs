// Подсчитать сумму элементов одномерного массива на нечетных позициях
Console.WriteLine("Задайте количество элементов одномерного массива");
int count = Convert.ToInt32(Console.ReadLine());
int[] number = new int[count];
FillArray(number, -9, 9);
PrintArray(number);
Console.WriteLine($"Сумма чисел в массиве на нечетных позициях= {SumUnevenNumbers(number)}");

void FillArray(int[] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        Console.WriteLine();
    }
}

int SumUnevenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}