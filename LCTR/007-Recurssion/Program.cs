int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
void Towers(string with = "1", string on = "2", string some = "3", int count = 3)
{                                                       //Ханойские башни
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1     2   3     4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1) // Обход математического выражения (4-2)*(1+3)/10
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if ( left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if ( right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);

    }
}
//FindWords("аисв", new char[2]);
//Towers();
InOrderTraversal();
