﻿
Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

CreateStringArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(GetNewArray(array));

void CreateStringArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine()!;
    }
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[0] == " ")
            Console.Write("");

        else if (i == arr.Length - 1)
            Console.Write($"'{arr[i]}'");
        else
            Console.Write($"'{arr[i]}', ");
    }
    Console.Write("]");
}

string[] GetNewArray(string[] arr)
{
    string[] newArray;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    if (count != 0)
    {
        newArray = new string[count];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArray[j] = arr[i];
                j++;
            }
        }
    }
    else newArray = [" "];
    return newArray;

}
