
CreateArray ();

void CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine()!;
    }

    Console.WriteLine(string.Join(",", array));
}