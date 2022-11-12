// Массив из 12 элементов [-9;9], найти суммы положительных и отрицательных чисел в массиве
int[] numbers = new int[12];
FillArray(numbers);
PrintArray(numbers);
int sumPositive = GetSumPositiveNumbers(numbers);
int sumNegative = GetSumNegativeNumbers(numbers);
Console.WriteLine($"Сумма положительных чисел={sumPositive} ");
Console.WriteLine($"Сумма отрицательных чисел={sumNegative} ");
(int, int) result=GetSumNegativeUndPoditiveNumbers(numbers);
Console.WriteLine($"Сумма отрицательных чисел={result.Item1} , а положительных={result.Item2}");
void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 9);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetSumPositiveNumbers(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

int GetSumNegativeNumbers(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

(int, int) GetSumNegativeUndPoditiveNumbers(int [] array)
{
    int sumNeg=0;
    int sumPos=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
        {
            sumNeg+=array[i];
        }
        else
        {
            sumPos+=array[i];
        }
    }
    return (sumNeg, sumPos);
}