void Zadacha046()
{   //Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера: {rows} x {columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
}
void Zadacha048()
{   //Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
    //Выведите полученный массив на экран.Random random = new Random();
    Console.WriteLine("Введите m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int rows = m;
    int columns = n;
    Console.WriteLine($"Массив размера: {rows} x {columns}");
    int[,] numbers = new int[rows, columns];
    FillArray2(numbers);
    PrintArray(numbers);
}
void Zadacha049()
{   //Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера: {rows} x {columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)       //Если оба счетчика увеличивать на 2 и начинать с 2х, то иф не нужен
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                numbers[i, j] = numbers[i, j] * numbers[i, j];
            }
        }
    }
    Console.WriteLine("-------------------");
    PrintArray(numbers);
}
void Zadacha051()
{   //Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
    //(с индексами (0,0); (1;1) и т.д.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    int summ = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                summ = summ + numbers[i, j];
            }
        }
    }
    Console.WriteLine("Сумма элементов главной диагонали: " + summ);


}
void ZadachaDop()
{   //Дан двумерный массив из двух строк и двадцати двух столбцов. В его первой строке записано количество мячей, забитых футбольной 
    //командой в той или иной игре, во второй — количество пропущенных мячей в этой же игре.
    //а) Для каждой проведенной игры напечатать словесный результат: "выигрыш", "ничья" или "проигрыш".
    //б) Определить количество выигрышей данной команды.
    //в) Определить количество выигрышей и количество проигрышей данной команды.
    //г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды.
    //д) Определить, в скольких играх разность забитых и пропущенных мячей была большей или равной трем.
    // е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью — 1, за проигрыш — 0).
    int rows = 2;
    int columns = 22;
    int[,] numbers = new int[rows, columns];
    FillArrayCustom(numbers, 0, 9);
    PrintArray(numbers);
    // for (int i = 0; i < numbers.Length; i++)             //A
    // {
    //     for (int j = 0; j < numbers.Length; j++)
    //     {
    //         if (numbers[i, j] == numbers[i + 1, j]) Console.WriteLine(numbers[i, j] + ":" + numbers[i + 1, j] + " = " + "Ничья");
    //         else if (numbers[i, j] > numbers[i + 1, j]) Console.WriteLine(numbers[i, j] + ":" + numbers[i + 1, j] + " = " + "Выигрыш");
    //         else if (numbers[i, j] < numbers[i + 1, j]) Console.WriteLine(numbers[i, j] + ":" + numbers[i + 1, j] + " = " + "Проигрыш");
    //     }
    // }

    // for (int i = 0; i < numbers.Length; i++)         //B
    // {
    //     for (int j = 0; j < numbers.Length; j++)
    //     {
    //         if (win > lose) 
    //         {
    //             x = 1 + x;
    //         }
    //     }
    // }
    // Console.WriteLine("Количество выигрышей: " + x);
}
void ZadachaDop002()
{   //Предыдущаяя задача - решение с Сапрыкиным
    int rows = 2;
    int columns = 22;
    int[,] numbers = new int[rows, columns];
    FillArrayCustom(numbers, 0, 9);
    PrintArray(numbers);
    int win = 0;
    int draw = 0;
    int lose = 0;
    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] > numbers[1, i])
        {
            Console.WriteLine($"{numbers[0, i]} : {numbers[1, i]} - win");
            win++;
        }
        if (numbers[0, i] == numbers[1, i])
        {
            Console.WriteLine($"{numbers[0, i]} : {numbers[1, i]} - draw");
            draw++;
        }
        if (numbers[0, i] < numbers[1, i])
        {
            Console.WriteLine($"{numbers[0, i]} : {numbers[1, i]} - lose");
            lose++;
        }
    }
    Console.WriteLine($"Количество: побед - {win}, поражений - {lose}, ничьих - {draw}");
    Console.WriteLine($"Количество набранных очков: {win*3+draw}");
}
void ZadachaDop003()
{   //На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
    Console.Clear();
    string phrase = "без труда не выловишь и рыбку из пруда";
    char[] alphabet = {'а','е','ё','и','о','у','ы','э','ю','я'};
    int count = 0;
    // foreach(char letter in phrase)
    // {
    //     bool contain = alphabet.Contains(letter);
    //     if (contain) count++;
    //     Console.WriteLine($"Буква {letter} гласная: {alphabet.Contains(letter)}" );
    // }
    // Console.WriteLine($"в поговорке {count} гласных букв");
    int CountOfVowelLetters(string phrase, char[] alphabet, int count = 0, int index = 0)
    {
        if(index == phrase.Length) return count;
        bool contain = alphabet.Contains(phrase[index]);
        if (contain) count++;
        index++;
        return CountOfVowelLetters(phrase, alphabet, count, index);
    }
    Console.WriteLine($"в поговорке {CountOfVowelLetters(phrase, alphabet)} гласных букв");
}
void FillArray2(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
        }
    }
}
void FillArrayCustom(int[,] numbers, int minBalls = 0, int maxBalls = 1)
{
    maxBalls++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(minBalls, maxBalls);
        }
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
            Console.Write(numbers[i, j] + " ");
            //Console.Write(numbers[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
//Zadacha046();
//Zadacha048();
//Zadacha049();
//Zadacha051();
//ZadachaDop();
//ZadachaDop002();
//ZadachaDop003();


