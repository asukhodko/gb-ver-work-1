string[] a = {"hello", "2", "world", ":-)"};
PrintArray(a);

void PrintArray(string[] arr)
{
    Console.Write($"[{String.Join(", ", arr)}]");
    Console.WriteLine();
}
