/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] fillArray(int lengthForFill)
{
    int[] result = new int[lengthForFill];
    for (int i = 0; i < lengthForFill; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}
void printArray(int[] arrayForPrint)
{
    Console.Write("[");
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
int[] productPairsNumbers(int[] arrayForProduct) //Основная функция... для записи искомого массива
{
    int lengthResult = 0;
    if (arrayForProduct.Length % 2 == 0)
    {
        lengthResult = arrayForProduct.Length / 2;
    }
    else
    {
        lengthResult = arrayForProduct.Length / 2 + 1;
    }
    int[] result = new int[lengthResult];
    for (int i = 0; i < arrayForProduct.Length / 2; i++)
    {
        result[i] = arrayForProduct[i] * arrayForProduct[(arrayForProduct.Length - 1) - i];
    }
    //Можно было занести следующее условие в цикл for, но я решил сделать отдельно, что бы была только одна проверка.
    if(arrayForProduct.Length % 2 != 0)
    {
        result[lengthResult - 1] = arrayForProduct[arrayForProduct.Length / 2];
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
int[] basicArray = fillArray(length);
int[] productArray = productPairsNumbers(basicArray);
Console.WriteLine($"\nИзначальный массив из {basicArray.Length} элементов: ");
printArray(basicArray);
Console.WriteLine("\nИтоговый массив из произведений пар изначального массива: ");
printArray(productArray);