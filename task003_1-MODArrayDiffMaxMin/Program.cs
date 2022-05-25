﻿/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//Это модифицированный вариант задачи №38 (task003). Добавил возможность выбора типа заполнения массива.

double[] fillArrayOption(int lengthForFill, string type) //заполняет массив относительно выбора с консоли
{
    double[] result = new double[lengthForFill];
    if(type.ToLower() == "y")
    {
        int randomType;
        double randomChioce;
        for (int i = 0; i < lengthForFill; i++)
        {
            randomType = new Random().Next(0, 2);
            if (randomType == 1)
            {
                randomChioce = new Random().NextDouble() * 100;
                result[i] = Math.Round(randomChioce, 1);
            }
            else
            {
                randomChioce = new Random().Next(1, 101);
                result[i] = Math.Round(randomChioce, 1);
            }
        }
    }
    else if (type.ToLower() == "n")
    {
        Console.WriteLine($"Введите любые {lengthForFill} чисел (вещественыне или натуральные): ");
        for (int i = 0; i < lengthForFill; i++)
        {
            result[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return result;
}

void printArray(double[] arrayForPrint)
{
    Console.WriteLine("\nПолученный массив: ");
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1)
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine("]");
}

void findDifferenceMinMax(double[] arrayForFind) //основная функция для поиска и печати заданного результата
{
    double max = arrayForFind[0];
    double min = arrayForFind[0];
    for (int i = 1; i < arrayForFind.Length; i++)
    {
        if (arrayForFind[i] > max)
        {
            max = arrayForFind[i];
        }
        if (arrayForFind[i] < min)
        {
            min = arrayForFind[i];
        }
    }
    double result = max - min;
    Console.WriteLine($"\n{max} - {min} = {result} (разница макс. и мин. элементов индекса)");
    //иногда в ответе может вылететь "= *,000000000000006", но я решил сюда не ставить МасРаунд, потому что ручной ввод может быть например 5,4565 или 5,1354812
}

Console.Write("Введите размер массива (при значении 0 будет задан случайный размер от 4 до 15): ");
int length = Convert.ToInt32(Console.ReadLine());
int tempLength = length;

if (tempLength == 0)
{
    length = new Random().Next(4, 16); //при значении 0 будет массив рандомной длинны от 4 до 15
}

Console.Write("Заполнить массив случайными вещественными числами от 1 до 100? (Y / N): ");
string? choice = Console.ReadLine(); //записываем "выбор"

if (choice?.ToLower() == "y" || choice?.ToLower() == "n") //действия выполняется при правильном выборе
{
    double[] array = fillArrayOption(length, choice);
    printArray(array);
    findDifferenceMinMax(array);
}
else
{
    Console.WriteLine("\nНеверный ввод, попробуйте ещё раз!");
}