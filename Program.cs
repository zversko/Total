int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void InputArray(string[] args)
{
    int length = args.Length;
    int i = 0;
    while (i < length)
    {
        Console.WriteLine($"Введите {i}-й элемент", i + 1);
        args[i] = Console.ReadLine();
        i++;
    }
    Console.WriteLine();
}

void PrintItems(string[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3) Console.WriteLine($"{i}. {array[i]} ");
    }
    Console.WriteLine();
}

void Main()
{
    string[] array = new string[InputNumber("Введите размер массива - ")];
    InputArray(array);
    PrintItems(array);
}

Main();