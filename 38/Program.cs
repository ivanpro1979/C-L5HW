// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int max = 0;
int min = 100;
int[] array = GetArray(8);
Console.WriteLine($" [ {String.Join(",", array)} ] ");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:" + (max - min));
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
        if (result[i] > max) max = result[i];
        if (result[i] < min) min = result[i];
    }
    return result;
}