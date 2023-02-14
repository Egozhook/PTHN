void Zadacha001()
{
    // Задача: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру в этом числе
    Random random = new Random();
    int number = random.Next(10, 100); // Next - полуинтервал. 10 входит (может выпасть), а 100 - нет
    Console.WriteLine(number);
    int tens = number / 10;
    int ones = number % 10;
    Console.WriteLine(tens);
    Console.WriteLine(ones);
    if (tens > ones)
    {
        Console.WriteLine("Наибольшее:" + tens);
        Console.WriteLine("Наименьшее:" + ones);
    }
    else
    {
        Console.WriteLine("Наибольшее:" + ones);
        Console.WriteLine("Наименьшее:" + tens);
    }

}
void Zadacha002()
{
    // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    Random random = new Random();
    int number = random.Next(100, 1000);
    Console.WriteLine(number);
    int hund = number / 100;
    int tens = number / 10 % 10;
    int ones = number % 10;
    Console.WriteLine("Ответ:" + hund + ones);

}
void Zadacha002v2()
{   // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    int number = new Random().Next(100, 1000); // Если рандомное число вызывается один раз - можно так делать 
                                               //  (без создания дополнительного объекта для рандома)
    int a = number / 100;
    int b = number % 10;
    string c = Convert.ToString(a) + Convert.ToString(b);
    Console.WriteLine(number);
    Console.WriteLine(c);
}
void Zadacha003()
{   // Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
    //число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a % b;
    if (c == 0)
    {
        Console.WriteLine($"Число {a} кратно {b}");
    }
    else
    {
        Console.WriteLine($"Число {a} НЕкратно {b}. Остаток: {c}");

    }
}
void Zadacha004()
{   //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 7 + a % 23 == 0) // Сложное условие if (a % 7 == 0 && a % 23 == 0) && - логическое И || - логическое ИЛИ
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
void Zadacha005()
{   //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a == b * b || b == a * a) Console.WriteLine("да");
    else Console.WriteLine("Нет");
}
//Zadacha001();
//Zadacha002();
//Zadacha002v2();
//Zadacha003();
//Zadacha004();
//Zadacha005();