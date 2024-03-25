// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// // неотрицательных числа m и n.
int Accerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (n == 0)
        return Accerman(m - 1, 1);
    else
        return Accerman(m - 1, Accerman(m, n - 1));
}

Console.Write("ВВедите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Accerman(m, n));