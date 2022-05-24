/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//Random rand = new Random();
double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    //array[i]=rand.NextDouble() * 40 - 20;
    array[i] = Math.Round((new Random().NextDouble()- 2-1), 2);
    //array[i] = Convert.ToDouble(Console.ReadLine());
}
string arr = string.Join(" ", array);
System.Console.WriteLine(arr);