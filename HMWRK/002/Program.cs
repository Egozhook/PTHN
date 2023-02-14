//Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все
//чётные числа от 1 до N.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (num > count)
{
    Console.Write(count + ", ");
    count=count+2;
}