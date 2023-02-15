void Zadacha024()
{   //: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
    int number = 15;
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        sum += i;
    }
    Console.WriteLine($"{sum}");

}
void Zadacha026()
{   //Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    while (num > 0)
    {
        num = num / 10;
        counter = counter + 1;
    }
    Console.Write($"В числе - {counter} цифр(ы)");
    //Альтернативное решение - более рациональное
    // Console.WriteLine("Введите число:");
    // string number = Console.ReadLine();
    // Console.WriteLine(number.Length);
    // -------------------------------------
    // еще решение - через логарифм
    // Console.WriteLine("\n \t Task 24");
    // Console.Write("Enter number:");
    // int num = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine($"{num} -> {Math.Ceiling(Math.Log10(num))}");
}
void Zadacha028()
{   //Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    int current_number = num;
    int sum = 1;
    while (current_number > 0)
    {   
        sum = sum * current_number;
        current_number = current_number - 1;
     }
     Console.WriteLine($"Произведение чисел от 1 до {num} равно {sum}");
}
void Zadacha030()
{   //Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
    Random random = new Random();
    int size = random.Next(4,10);
    int[] numbers = new int [size];
    Console.WriteLine($"Размер массива - {size}");
    FillArray(numbers);
    PrintArray(numbers);
   
    void FillArray(int[] num)
    {
        Random random = new Random();
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = random.Next(0,2);
        }
    }
    void PrintArray(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + "\t");
    }
     Console.WriteLine();
    }
   

}
//Zadacha024();
//Zadacha026();
//Zadacha028();
Zadacha030();

