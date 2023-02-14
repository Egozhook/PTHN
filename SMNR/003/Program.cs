void Zadacha17()
{
    //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
    //номер четверти плоскости, в которой находится эта точка.
    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"A({x}, {y})");
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка лежит в 1 четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка лежит во 2 четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка лежит в 3 четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка лежит в 4 четверти");
    }
    else
    {
        Console.WriteLine("Точка лежит на одной из осей");
    }
}
void Zadacha18()
{
    // Напишите программу, которая по заданному номеру четверти, показывает диапазон
    // возможных координат точек в этой четверти (x и y).
    Console.WriteLine("Введите номер четверти:");
    int Qrt = Convert.ToInt32(Console.ReadLine());
    if (Qrt <= 4)
    {
        if (Qrt == 1) Console.WriteLine("x: от нуля до + ∞, у: от нуля до + ∞");
        else if (Qrt == 2) Console.WriteLine("x: от нуля до - ∞, у: от нуля до + ∞");
        else if (Qrt == 3) Console.WriteLine("x: от нуля до - ∞, у: от нуля до - ∞");
        else if (Qrt == 4) Console.WriteLine("x: от нуля до + ∞, у: от нуля до - ∞");
    }
    else Console.WriteLine("Неверный ввод");

}
void Zadacha21()
{
    //Напишите программу, которая принимает на вход координаты двух точек и
    //находит расстояние между ними в 2D пространстве.
    Console.WriteLine("Введите координаты точки А: x = :");
    int x_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А: у = :");
    int y_first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки Б: х = :");
    int x_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А: у = :");
    int y_second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(x_second - x_first, 2) + Math.Pow(y_second - y_first, 2))}");

}
void Zadacha22()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
    //квадратов чисел от 1 до N.
    // Console.WriteLine("Введите число:");
    // int x = Convert.ToInt32(Console.ReadLine());
    // int count = 1;
    // while (count <= x)
    // {
    //     Console.Write($"{count * count}; ");
    //     count++;
    // }
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число\tКвадрат");
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i, 2));
    }


}
//Zadacha17();
//Zadacha18();
//Zadacha21();
//Zadacha22();
