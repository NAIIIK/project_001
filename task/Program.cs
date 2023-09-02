// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Метод для получения данных от пользователя
string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

// Метод для получения элементов массива от пользователя
string[] InputArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Prompt($"Введите {i + 1}-ый элемент массива: ");
    }
    return result;
}

// Метод для печати массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// Метод для получения массива элементов с длиной >= 3
string[] NewArray(string[] array)
{
    string[] result = new string[array.Length];
    int resultSize = 0;
    // Отдельная переменная индекса искомого массива
    foreach (string arg in array)
    {
        if (arg.Length <= 3)
        {
            result[resultSize] = arg;
            resultSize++;
        }
    }
    return result;
}

Console.Clear();

int arrayLength = int.Parse(Prompt("Введите размер массива: "));

string[] stringArray = InputArray(arrayLength);

Console.Write("Введённый массив --> ");

PrintArray(stringArray);

string[] resultArray = NewArray(stringArray);

Console.Write("\nИскомый массив --> ");

PrintArray(resultArray);