// Сокрашение времени алгоритма заполнения таблицы путе отзеркаливания по диагонали


using System;
using static System.Console;
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($"{matrix[i, j], 2:F0}");
        Write(" ");
    }
    WriteLine();
}

