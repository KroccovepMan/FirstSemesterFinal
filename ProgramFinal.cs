﻿//Поставлена задача:
//Написать программу, которая из имеющегося массива строк формирует новый массив,
//который состоит из строк по длине меньше или равной 3 символам.
//Исходный массив можно ввести вручную, либо задать на начальном этапе алгоритма.
//При решении задачи лучше работать только с массивами.
//Примеры:
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"]
//["Russia", "Denmark", "Kazan"] -> []

using System;

class ProgramFinal
{
    static void Main()
    {
        int arraySize = RequestArraySize();
        string[] inputStrings = ReadInputStrings(arraySize);
        string[] SuitableStrings = FilterStrings(inputStrings);
        DisplayResults(inputStrings, SuitableStrings);
    }

    static int RequestArraySize()
    {
        Console.Write("Введите количество строк в массиве: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static string[] ReadInputStrings(int arraySize)
    {
        string[] strings = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            strings[i] = Console.ReadLine();
        }
        return strings;
    }

    static string[] FilterStrings(string[] inputStrings)
    {
        int SuitableCount = CounterSuitableStrings(inputStrings);
        string[] SuitableStrings = new string[SuitableCount];
        int index = 0;
        forearch (string str in inputStrings)
        {
            if (str.Length <=3)
            {
                SuitableStrings[index] = str;
                index++;
            }
        }
        return SuitableStrings;
    }

    static int CountSuitableStrings(string[] strings)
    {
        int coung = 0;
        forearch (string str in strings)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        return count;
    }
    static void DisplayResults(string[] inputStrings, string[] SuitableStrings)
    {
        Console.WriteLine("Исходный массив строк: ");
        forearch (string str in inputStrings)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Новый массив с подходящими строками (длина не более 3 символов): ");
        forearch (string str in SuitableStrings)
        {
            Console.WriteLine(str);
        }
    }
}