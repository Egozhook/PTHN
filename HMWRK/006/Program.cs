void Zadacha041()
{   // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine("Введите количество чисел (М):");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Введите число:");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Чисел больше нуля:" + count);
}
void Zadacha043()
{   //Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    Console.WriteLine("Введите значение b1:");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1:");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2:");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2:");
    int k2 = Convert.ToInt32(Console.ReadLine());
    int x = (b2 - b1) / (k1 - k2);
    if (k1*x + b1 == k2*x +b2)
    {
        Console.WriteLine($"Точка пересечения: ({x};{k1*x + b1})");
    }
    else Console.WriteLine("Линии не пересекаются");
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
Zadacha041();
//Zadacha043();