
void FillArray(int[] numbers, int minValue = -1000, int maxValue = 1000)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//Zadacha34();
void Zadacha34()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.WriteLine("Количество четных элементов :" + count);
}
// Задача37.Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов с нечётными индексами.
//Zadacha37();
void Zadacha37()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    int sum = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
        if (i % 2 == 1) sum += numbers[i];

    }
    Console.WriteLine("Количество четных элементов :" + count);
    Console.WriteLine("Сумма элементов с нечётными индексами :" + sum);
}
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Zadacha38();
void Zadacha38()
{
    int size = 8;
    double[] numbers = new double[size];

    FillArrayD(numbers, 10, 100);
    PrintArrayD(numbers);
    Difference(numbers);
}
void Difference(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min) min = numbers[i];
        if (numbers[i] > max) max = numbers[i];
    }
    Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
}
void FillArrayD(double[] numbers, int minValue = -1000, int maxValue = 1000)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(random.NextDouble() * 10, 2);
    }
}
void PrintArrayD(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}