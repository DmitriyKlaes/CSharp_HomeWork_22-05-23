/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] fillArray(int lengthForFill)
{
    int[] result = new int[lengthForFill];
    for (int i = 0; i < lengthForFill; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}
void printArray(int[] arrayForPrint)
{
    Console.Write("\n["); //отступает одну строку перед распечатной массива
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int positiveCount(int[] arrayForFind)
{
    int result = 0;
    for (int i = 0; i < arrayForFind.Length; i++)
    {
        if (arrayForFind[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}
Console.Write("Введите размер массива (при значении 0 будет задан случайный размер от 4 до 15): ");
int length = Convert.ToInt32(Console.ReadLine());
int tempLength = length;
if (tempLength == 0)
{
    length = new Random().Next(4,16);
}
int[] array = fillArray(length);
int count = positiveCount(array);
printArray(array);
Console.WriteLine($"В данном массиве из {length} элементов чётными являются: {count}");