void Zadacha001()
{   //Напишите программу, которая на вход принимает два числа и выдаёт, 
    //какое число большее, а какое меньшее.

    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int max = num1; // Ошибка - макс ту нахрен не нужен. У нас же два числа всего!!!
    if (num2 > max)
    {
        Console.WriteLine("Большее число: " + num2);
        Console.WriteLine("Меньшее число: " + num1);
    }
    else if (num2 == max)
    {
        Console.WriteLine("Числа равны");

    }
    else
    {
        Console.WriteLine("Большее число: " + num1);
        Console.WriteLine("Меньшее число: " + num2);
    }
}
void Zadacha002()
{
    //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int max = num1;
    if (num2 > max)
    {
        max = num2;
        if (num3 > max)
        {
            max = num3;
        }
    }
    else if (num3 > max) //Лишний if можно было сравнить только два раза последовательно
    {
        max = num3;
    }
    Console.WriteLine("Большее число: " + max);
}
void Zadacha003()
{
    // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int ostatok = num % 2;
    if (ostatok == 0)
    {
        Console.WriteLine("Число четное");
    }
    else Console.WriteLine("Число нечетное");
}
void Zadacha004()
{
    //Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все
    //чётные числа от 1 до N.
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 2;
    while (num > count)
    {
        Console.Write(count + ", ");
        count = count + 2;
    }
}

//Zadacha001();
//Zadacha002();
//Zadacha003();
//Zadacha004();
