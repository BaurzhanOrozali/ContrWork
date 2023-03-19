// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которой меньше или равна 3 символов. Первоначальный массив можно ввести с помощью клавиатуры 
// либо задать на старте выполнения алгоритма. При решений не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] Replase (string[] text)
{
    string [] Array = new string[text.Length];
    int element = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if(text[i].Length <= 3) 
        {
            Array[element] = text[i];
            element++;
        }
    }
    string [] result = new string[element];
    for (int i = 0; i < element; i++)
    {
        result[i] = Array[i];
    }
    return result;
}
void InputStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter element size [{i + 1 }]: ");
        array[i] = Console.ReadLine();
    }
}
void PrintStringArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"[{array[i]}] ");
}

Console.Write("Enter string array length: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] myStringArray = new string[arraySize];
InputStringArray(myStringArray);
string[] NewText = Replase(myStringArray);
Console.WriteLine();
Console.WriteLine("Array with element length <= 3: ");
PrintStringArray(NewText);













