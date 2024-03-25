// // Задача 1: Задайте значения M и N. 
// // Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// // Использовать рекурсию, не использовать циклы.

string natural_numbers(int m, int n)
{
    if (n == m) return Convert.ToString(n);
    return m + " " + natural_numbers(m + 1, n);
}

Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(natural_numbers(M, N));