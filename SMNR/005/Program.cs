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
void Zadacha035()
{   //Задайте одномерный массив из 10 случайных чисел.Найдите количество элементов массива, 
    //значения которых лежат в отрезке [10,99].
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 101);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 9 && numbers[i] < 100)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {count}");
}
void Zadacha037()
{   //Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, 
    //второй и предпоследний и т.д. Результат запишите в новом массиве.
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        Console.WriteLine($"{numbers[i]} * {numbers[maxIndex - i]} = {numbers[i] * numbers[maxIndex - i]} ");
    }
    if (size % 2 == 1)
    {
        Console.WriteLine(numbers[size / 2]);
    }
    Console.WriteLine();
}
void ZadachaD002()
{   //Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц.
    //Размер массива должен совпадать с квадратом количества единиц в нем
    Random random = new Random();
    int countOnes = random.Next(1, 11);
    Console.WriteLine("Количество единиц" + countOnes);
    int size = countOnes * countOnes;
    int[] numbers = new int [size];
    int randomIndex = random.Next(0, size);
    for (int i = 0; i < countOnes; i++)
    {
        while (numbers[randomIndex] == 1)
        {
            Console.WriteLine($"Элемент {randomIndex + 1 } уже равен 1, ищем следующий");
            randomIndex = random.Next(0, size);
        }
        numbers[randomIndex] = 1;            
        Console.WriteLine($"Элемент {randomIndex + 1 } равен 1");
    }
    PrintArray(numbers);

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
//Zadacha033();
//Zadacha035();
//Zadacha037();
//ZadachaD002();

