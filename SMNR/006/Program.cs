void Zadacha039()
{   //Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
    //месте, а первый - на последнем и т.д.)
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    ReverseArray(numbers);
    PrintArray(numbers);
}
void Zadacha040()
{   //Напишите программу, которая принимает на вход три числа и проверяет, 
    //может ли существовать треугольник состоронами такой длины.
    //Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число:");
    int c = Convert.ToInt32(Console.ReadLine());
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine($"Треугольник со сторонами {a},{b},{c} - существует");
    }
    else Console.WriteLine($"Треугольник со сторонами {a},{b},{c} - не существует");
}
void Zadacha042()
{   //Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    // Console.WriteLine("Введите число:");                 //короткое решение
    // int number = Convert.ToInt32(Console.ReadLine());
    // string result = Convert.ToString(number, 2);
    // Console.WriteLine(result);
    Random RundNum = new Random();
    int Num = RundNum.Next(0, 101);
    int Num10 = Num;
    double NumAs2 = 0;
    double i = 0;
    while (Num10 > 0)
    {
        NumAs2 = (Num10 % 2) * Math.Pow(10, i) + NumAs2;
        Num10 /= 2;
        i += 1;
    }
    Console.WriteLine($"Число {Num} в двоичном коде: {NumAs2}");
}
void Zadacha044()
{   // Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
    Console.WriteLine("Введите нужное количество чисел Фибоначчи:"); // решение через массив
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];                                  // лучше использовать double, чтобы не было переполнения
    numbers[0] = 0;
    numbers[1] = 1;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }
    PrintArray(numbers);


}
void Zadacha045()
{   //Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
    int size = 10;
    int[] numbers = new int[size];
    int[] others = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        others[i] = numbers[i];
    }
    PrintArray(others);

}
void Test(int test = 0)
{
    if (test == 100) return; // выход из рекурсии (лучше делать в начале)
    test++;
    Console.WriteLine (test);
    Test(test);
}
void ReverseArray(int[] numbers)
{
    int size = numbers.Length;
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        // int temp = numbers[i];
        // numbers[i] = numbers[maxIndex - i];
        // numbers[maxIndex - i] = temp;
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]); // кортеж чисел
    }
}
void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива:");

    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}
//Zadacha039();
//Zadacha040();
//Zadacha042();
//Zadacha044();
//Zadacha045();
Test();

