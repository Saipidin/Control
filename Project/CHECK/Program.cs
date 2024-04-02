using System;

class Program
{
    static void Main(string[] args)
    {
        // Примеры массивов строк
        string[][] examples = {
            new string[] { "Gif", "312", "4333", "sing" },
            new string[] { "0-===-", "/*-", "qaz", "sun" },
            new string[] { "love", "911", "/-/", "women" }
        };

        foreach (string[] inputArray in examples)
        {
            string[] newArray = FilterStrings(inputArray);

            Console.WriteLine("Исходный массив:");
            PrintArray(inputArray);
            Console.WriteLine("Отфильтрованный массив:");
            PrintArray(newArray);
            Console.WriteLine();
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        // Подсчитываем количество строк, длина которых меньше или равна 3 символам
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив для хранения строк длиной не более 3 символов
        string[] newArray = new string[count];
        int newIndex = 0;

        // Формируем новый массив
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newArray[newIndex++] = inputArray[i];
            }
        }

        return newArray;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("\"" + array[i] + "\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
