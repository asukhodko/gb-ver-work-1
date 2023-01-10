string[] a = { "hello", "2", "world", ":-)" };
PrintArray(a);
string[] b = FilterArray(a);
PrintArray(b);

void PrintArray(string[] arr)
{
    Console.Write($"[{String.Join(", ", arr)}]");
    Console.WriteLine();
}

string[] FilterArray(string[] a)
{
    int j = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            a[j] = a[i];
            j++;
        }
    }

    string[] b = new string[j];
    for (int i = 0; i < b.Length; i++)
    {
        b[i] = a[i];
    }

    return b;
}

/*
asukhodko@MBP-Aleksandr src % dotnet run                                     
[hello, 2, world, :-)]
[2, :-)]
*/
