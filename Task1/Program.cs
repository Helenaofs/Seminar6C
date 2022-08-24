// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

using System;

Console.Write("Введите колличество чисел: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];

void CreateNumbers(int nums)
{
    for (int i = 0; i < nums; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    return count;
}

CreateNumbers(M);
Console.WriteLine($"Чисел больше 0: {CountNumbers(array)} ");
