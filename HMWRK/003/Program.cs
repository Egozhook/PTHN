void Zadacha001()
{   //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.WriteLine("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int digit = Math.Abs(number);            // вечно забываю модуль!!!
    if (digit > 9999 && digit < 100000)
    {
        if (digit / 10000 == digit % 10)
        {
            if (digit / 1000 % 10 == digit / 10 % 10)
            {
                Console.WriteLine($"Число {digit} - палиндром");
            }
            else Console.WriteLine($"Число {digit} - не является палиндромом");

        }
        else Console.WriteLine($"Число {digit} - не является палиндромом");
    }
    else Console.WriteLine("Неверный ввод");
}
void Zadacha001A()
{   // Решение Сапрыкина
    int number = 12321;
    int current_number = number;
    int result = 0;
    while (current_number > 0)
    {
        int digit = current_number % 10;
        result = result * 10 + digit;
        current_number /= 10;
        Console.WriteLine(result);
    }
    if ( number == result)
    {
        Console.WriteLine($"Число {number} - палиндром");
    }
}
void Zadacha002()
{   //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Введите координаты точки А: x = :");
    int x_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А: у = :");
    int y_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А: z = :");
    int z_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки Б: х = :");
    int x_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А: у = :");
    int y_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А: z = :");
    int z_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(x_second - x_first, 2) + Math.Pow(y_second - y_first, 2) + Math.Pow(z_second - z_first, 2))}");
}
void Zadacha003()
{   //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число\tКуб");
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i, 3));
    }

}
//Zadacha001();
//Zadacha001A();
//Zadacha002();
//Zadacha003();