void Zadacha034()
{   //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
    //программу, которая покажет количество чётных чисел в массиве.
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 99, 1000);
    PrintArray(numbers);
    int summ = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i]%2 ==0)
        {
            summ++;
        }
    }
    Console.WriteLine($"количетво четных элементов равно {summ}");

}
void Zadacha036()
{   //  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    int summ = 0;
    for (int i = 1; i < size; i= i + 2)
    {
        summ = summ + numbers[i];
    }
    Console.WriteLine(summ);
}
void Zadacha038()
{   //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
    Random random = new Random();
    int size = 10;
    double[] numbers = new double[size];
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < size; i++)
    {
        numbers[i] = Math.Round(random.NextDouble(),2); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    double max = numbers[0];
    double min = numbers[0];
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
        else if (numbers[i] > max)
        {
            max = numbers[i];
        } 
    }
    Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {max-min}");

}
void FillArray(int[] numbers, int minValue = -100, int maxValue = 100)
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
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}
//Zadacha034();
//Zadacha036();
//Zadacha038();
