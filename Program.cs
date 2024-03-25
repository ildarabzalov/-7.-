// // Задача 1: Задайте значения M и N. 
// // Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// // Использовать рекурсию, не использовать циклы.

// string natural_numbers(int m, int n)
// {
//     if (n == m) return Convert.ToString(n);
//     return m + " " + natural_numbers(m + 1, n);
// }

// Console.Write("Введите число: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(natural_numbers(M, N));

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// // неотрицательных числа m и n.
// int Accerman(int m, int n)
// {
//     if (m == 0)
//         return (n + 1);
//     else if (n == 0)
//         return Accerman(m - 1, 1);
//     else
//         return Accerman(m - 1, Accerman(m, n - 1));
// }

// Console.Write("ВВедите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("ВВедите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Accerman(m, n));

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