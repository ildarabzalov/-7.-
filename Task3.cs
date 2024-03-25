// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
            return;
        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1);
    }

        int[] arr = { 1, 2, 5, 0, 10, 34 };
        Console.WriteLine("Элементы массива с конца:");
        PrintArrayReverse(arr, arr.Length - 1);