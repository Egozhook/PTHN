void Zadacha001()
{   //Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine());
    int c = b * b;
    if (a == c)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else Console.WriteLine("Первое число не является квадратом второго");
}
void Zadacha002()
{   //Напишите программу, которая будет выдавать название дня недели по заданному номеру
    Console.WriteLine("Введите номер дня недели:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (a == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (a == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (a == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (a == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (a == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (a == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
void Zadacha003()
{   //Напишите программу вычисления значения функции возведения числа в квадрат.
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int Power(int x)
    {
        return x * x;
    }
    Console.WriteLine(Power(number));
}
//Zadacha001();
//Zadacha002();
//Zadacha003();


