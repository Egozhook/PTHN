void Zadacha047()
{   //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
    Console.WriteLine("Введите значение m:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение n:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Массив размера: {rows} x {columns}");
    double[,] numbers = new double[rows, columns];
    FillArrayDouble(numbers, rows, columns);
    PrintArrayDouble(numbers, rows, columns);
}
void Zadacha050()
{   //Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и 
    //возвращает значение этого элемента или же указание, что такого элемента нет.
    Random random = new Random();
    int rows = 2;
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера: 2 x {columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Введите первый индекс элемента(ряд):");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второй индекс элемента(колонка):");
    int second = Convert.ToInt32(Console.ReadLine());
    if (first >= numbers.GetLength(0)  || second >= numbers.GetLength(1))
    {
        Console.WriteLine("Элемента не существует");
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == first && j == second)
            {
                Console.WriteLine($"Значение элемента с индексом {first},{second}: {numbers[i, j]}");
            }
        }
    }

}
void Zadacha052()
{   // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Random random = new Random();
    int rows = 2;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Среднее арифметическое:");
    double a = (Convert.ToDouble(numbers[0,0]) + Convert.ToDouble(numbers[1,0]))/2;
    double b = (Convert.ToDouble(numbers[0,1]) + Convert.ToDouble(numbers[1,1]))/2;
    double c= (Convert.ToDouble(numbers[0,2]) + Convert.ToDouble(numbers[1,2]))/2;
    double d = (Convert.ToDouble(numbers[0,3]) + Convert.ToDouble(numbers[1,3]))/2;
    Console.WriteLine(a + "\t" + b + "\t" +c + "\t" + d);
}
void FillArrayDouble(double[,] numbers, int rows=0, int columns =0)
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round((random.NextDouble() * 200 - 100), 1);
        }
    }
}
void PrintArrayDouble(double[,] numbers, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 11);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void Zadacha52dop()      
{   // Степино решение - все суммы по колонкам записываются в новый одномерный массив и там уже делятся на количество элементов
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(2, 7);
    int columns = random.Next(3, 10);
    int[,] numbers = new int[rows, columns];
    double[] sum = new double[columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum[i] += numbers[j, i];
        }
    }
    PrintArrayDouble(sum, rows, columns);
    Console.WriteLine();
    for (int i = 0; i < columns; i++)
    {
        Console.Write(Math.Round(sum[i]/rows, 2) + "\t");
    } 
}
//Zadacha047();
//Zadacha050();
//Zadacha052();
//Zadacha52dop();