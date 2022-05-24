/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] fillArray(int lengthForFill)
{
    int[] result = new int[lengthForFill];
    for (int i = 0; i < lengthForFill; i++)
    {
        result[i] = new Random().Next(-100, 101);
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
int summOddIndex(int[] arrayForSummOdds)
{
    int result = 0;
    for (int i = 1; i < arrayForSummOdds.Length; i = i + 2)
    {
        result = arrayForSummOdds[i] + result;
    }
    return result;
}
Console.Write("Введите размер массива (при значении 0 будет задан случайный размер от 4 до 15): ");
int length = Convert.ToInt32(Console.ReadLine());
int tempLength = length;
if (tempLength == 0)
{
    length = new Random().Next(4, 16);
}
int[] array = fillArray(length);
int summ = summOddIndex(array);
printArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {summ}");