int[] array = {12, 65, 18, 32, 72, 98, 47, 5};
int n = array.Length;
int find = 47;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}