﻿
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


/*
string[] array = {"hello", "2", "world", ":-)"};

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + "  ");

    Console.WriteLine();
}
ShowArray(array);

void EditorStringArray(string[] array)
{
    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
        Console.Write(newArray[i] + " ");
    }
}
EditorStringArray(array);
*/