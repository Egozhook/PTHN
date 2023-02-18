void Zadacha031()
{   //: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
    //отрицательных и положительных элементов массива.
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    Console.WriteLine(GetSummPositive(numbers));
    Console.WriteLine(GetSummNegative(numbers));
}
void Zadacha032()
{   //Напишите программу замены элементов массива: положительные элементы замените на
    //соответствующие отрицательные, и наоборот.
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -100, 101);
    PrintArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = -numbers[i];
    }
    PrintArray(numbers);
}
void Zadacha033()
{   //Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
    Console.WriteLine("Введите число:");
    int digit = Convert.ToInt32(Console.ReadLine());
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -100, 101);
    PrintArray(numbers);
    // bool flag = false;
    // int i = 0;
    // while (!flag && i =< numbers.Length)
    // {
    //     if(digit == numbers[i])
    //     {
    //         flag = true;
    //     }
    //     i++;
    // }
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == digit)
        {
            Console.WriteLine($"Число {digit} в массиве есть");
        }
        else Console.WriteLine($"Числа {digit} в массиве нет");
        break;                                                      // не рекомендуется использовать, лучше ввести bool переменную (true/false)
    }
}
int GetSummPositive(int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            summ += numbers[i];
    }
    return summ;
}
int GetSummNegative(int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
            summ += numbers[i];
    }
    return summ;
}
void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
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
//Zadacha031();
//Zadacha032();
Zadacha033();