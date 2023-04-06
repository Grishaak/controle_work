// Задача: Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] InputCreateArray(int mNum)
{
    string[] arr = new string[mNum];
    for (int i = 0; i < mNum; i++)
    {
        Console.Write("Введите число в массив: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int Count(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArray(string[] arr, int size)
{
    string[] newArray = new string[size];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            newArray[k] = arr[i];
            k++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


Console.Write("Введите размер массива: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
string[] array = InputCreateArray(mNumber);
Console.WriteLine();
PrintArray(array);
int count = Count(array);
Console.WriteLine();
System.Console.WriteLine(count);
Console.WriteLine();
string[] newArray = NewArray(array, count);
PrintArray(newArray);