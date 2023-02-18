void Zadacha025()
{   // Используя определение степени числа, напишите цикл, который принимает 
    //на вход два натуральных числа (A и B) и возводит число A в степень B.
    //Степень числа с натуральным показателем — это результат многократного умножения числа на себя.
    Console.WriteLine("Введите число A:");
    int digA = Convert.ToInt32(Console.ReadLine());
    int current_number = digA;    // Ошибка! нужно ставить 1, так как может быть нулевая степень
    Console.WriteLine("Введите число B:");
    int digB = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= digB; i++)
    {
        current_number = current_number * digA;
    }
    Console.WriteLine($"Число {digA} в степени {digB} = {current_number}");

}
void Zadacha027()
{   //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Console.WriteLine("Введите любое число:");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int current_number = 0;
    while (number > 0)
    {
        current_number = current_number + number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр = {current_number}");
}
void Zadacha029()
{   //Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
    Random random = new Random();
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    SelectionSort(numbers);
    PrintArray(numbers);
    void FillArray(int[] num)
    {
        Random random = new Random();
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = random.Next(-100, 100);
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
    void SelectionSort(int[] num)
{
    for (int i = 0; i < num.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < num.Length; j++)
        {
            if(Math.Abs(num[j]) < Math.Abs(num[minPosition])) minPosition = j;
        }

        int temporary = num[i];
        num[i] = num[minPosition];
        num[minPosition] = temporary;
    }
    
}
}
//Zadacha025();
//Zadacha027();
Zadacha029();