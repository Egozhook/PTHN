//Вид 1 - ничего не принимают, ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор ..");
}
//Method1();

//Вид 2 - что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст Сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Text", count: 4);
//Вид 3 - ничего не принимают, что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);
// Вид 4 - и принимают, и возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "Z");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
//}

// Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//                 + "ежели бы вас послали вместо нашего милого"
//                 + "Винценгероде, вы бы взяли приступом согласие"
//                 + "прусского короля. Вы так красноречивы. Вы"
//                 + "дадите мне чаю?";
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int Length = text.Length;
//     for (int i =0; i < Length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}"; 
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '-');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

int[] arr = { 1, 5, 2, 6, 8, 3, 5, 6, 7, 8, 5, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);