string[] source = new string[4] {"Hello", "2", "world", ":-)"};
string[] result = new string[source.Length];

void filter_source_array(string[] source, string[] result)
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

void print_result_array(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

filter_source_array(source, result);
print_result_array(result);
