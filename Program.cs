string[] source = new string[4] {"Hello", "2", "world", ":-)"};
string[] result = new string[source.Length];

void SecondArrayWithIF(string[] source, string[] result)
{
    int count = 0;
    for (int i = 0; i < source.Length; i++)
    {
        if(source[i].Length <= 3)
        {
            result[count] = source[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(source, result);
PrintArray(result);
