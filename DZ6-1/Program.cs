﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt(string msg)
{
    System.Console.Write($"{msg} --> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-100, 100); 
    }
    return array;
}

void ShowArray(int[] array)  // вывод массива
{
    foreach(int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int PositiveNumber(int[] array)
{
    int countDigits = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) countDigits++;
    }
    return countDigits;
}

int len = InputInt($"Введите длину массива");
int [] array = Array(len);
ShowArray(array);
System.Console.WriteLine($"количество чисел в массиве больше 0 равно {PositiveNumber(array)}");
