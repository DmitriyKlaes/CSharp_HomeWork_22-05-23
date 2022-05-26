/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//Данный вариант сделан под условие задачи.
//Модифицированный вариант этой задачи находится в папке task003_1. 

double[] fillArray(int lengthForFill)
{
    double[] result = new double[lengthForFill];
    for (int i = 0; i < lengthForFill; i++)
    {
        result[i] = Convert.ToDouble(Console.ReadLine());
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
    Console.WriteLine($"\n{max} - {min} = {result} (разница макс. и мин. элементов массива)");
    //иногда в ответе может вылететь "= *,000000000000006", но я решил сюда не ставить МасРаунд, 
    //потому что ручной ввод может быть например 5,4565 или 5,1354812
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите любые {length} чисел (вещественыне или натуральные): ");
double[] array = fillArray(length);
printArray(array);
findDifferenceMinMax(array);