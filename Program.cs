
string[] FormNewArrayStringsGivenLength(string[] array, int lengtStr)
{
    string[] arr2 = new string[array.Length];
    int countIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengtStr)
        {
            arr2[countIndex] = array[i];
            countIndex++;
        }
    }

    string[] arr3 = new string[countIndex];
    for (int i = 0; i < countIndex; i++)
    {
        arr3[i] = arr2[i];
    }

    return arr3;
}

void PrintArray(string[] arr, string separator)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{separator}");
        else Console.Write($"{arr[i]}");
    }
}

void PrintDecoratedArray(string[] initialArrayStrings, string[] newArrayStrings)
{
    Console.Write("[");
    if (initialArrayStrings.Length > 0)
    {
        Console.Write("\"");
        PrintArray(initialArrayStrings, "\", \"");
        Console.Write("\"");
    }
    Console.Write("]");
    Console.Write(" --> ");
    Console.Write("[");
    if (newArrayStrings.Length > 0)
    {
        Console.Write("\"");
        PrintArray(newArrayStrings, "\", \"");
        Console.Write("\"");
    }
    Console.WriteLine("]");
    Console.WriteLine();
}


string[] array1 = new string[] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };
string[] array4 = new string[] {};
string[] array5 = new string[] { "", "1", "12", "123", "1234", "12345", "123456", "1234567", "12345678"};

int lengtString = 3; //  количство символов в строках не превышающих значение (меньше, либо равно)
string[] newArray;

newArray = FormNewArrayStringsGivenLength(array1, lengtString);
PrintDecoratedArray(array1, newArray);

newArray = FormNewArrayStringsGivenLength(array2, lengtString);
PrintDecoratedArray(array2, newArray);

newArray = FormNewArrayStringsGivenLength(array3, lengtString);
PrintDecoratedArray(array3, newArray);

newArray = FormNewArrayStringsGivenLength(array4, lengtString);
PrintDecoratedArray(array4, newArray);

newArray = FormNewArrayStringsGivenLength(array5, lengtString);
PrintDecoratedArray(array5, newArray);