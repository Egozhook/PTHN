void Zadacha001()
{
    //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.WriteLine("- - - - - - - - - - - - - - - - ");
    Console.WriteLine("Задача 001");
    Console.WriteLine("Введите трехзначное число:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num / 100 >= 10) Console.WriteLine("Неверный ввод"); // Ошибка - не прроверяет если число больше трехзначного
                                                             // if(num > 99 && num < 1000)  - else неверный ввод
    else Console.WriteLine($"Ответ:{num / 10 % 10}");
}
void Zadacha002()
{
    //Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    Console.WriteLine("- - - - - - - - - - - - - - - - ");
    Console.WriteLine("Задача 002");
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(number) < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int numberabs = Math.Abs(number);
        while (numberabs > 999)
        {
            numberabs = numberabs / 10;
        }
        int third = numberabs % 10;
        Console.WriteLine("Ответ:" + third);
    }
}
void Zadacha003()
{
    // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    Console.WriteLine("- - - - - - - - - - - - - - - - ");
    Console.WriteLine("Задача 003");
    Console.WriteLine("Введите цифру, обозначающую день недели :");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 7) Console.WriteLine("Неверный ввод");
    else if (num == 6 || num == 7)
    {
        Console.WriteLine("День выходной");
    }
    else Console.WriteLine("День рабочий");

}
//Zadacha001();
//Zadacha002();
//Zadacha003();