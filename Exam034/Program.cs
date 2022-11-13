// Подсчитать количество четных числе в массиве 3х значнх чисел
Console.WriteLine("Задайте количество элементов массива 3х значных чисел");
int count = Convert.ToInt32(Console.ReadLine());
int[] number = new int[count];
FillArray(number, 100, 999);
PrintArray(number);
Console.WriteLine($"Количество четных чисел в массиве = {CountEvenNumbers(number)}");

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

int CountEvenNumbers(int[] array)
{
    int temp=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
            temp++;
    }
    return temp;
}