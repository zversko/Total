int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
}

(string[], int) FindItems(string[] array)
{
    string[] resArray = new string[array.Length];
    int count = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resArray[j] = array[i];
            count++;
            j++;
        }
    }
    return (resArray, count);
}

void PrintArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"{a[i]}");
    }
    Console.WriteLine();
}

void Main()
{
    string[] array = new string[InputNumber("Введите размер массива - ")];
    InputArray(array);
    (string[] resArray, int count) = FindItems(array);
    Array.Resize(ref resArray, count);
    if (count == 0)
    {
        System.Console.WriteLine("Новый массив пуст");
    }
    else
    {
        PrintArray(resArray);
    }
}

Main();