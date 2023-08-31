// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine()!;
}

string[] InputArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Prompt($"Введите {i + 1}-ый элемент массива: ");
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int arrayLength = int.Parse(Prompt("Введите размер массива: "));

string[] strArray = InputArray(arrayLength);

PrintArray(strArray);