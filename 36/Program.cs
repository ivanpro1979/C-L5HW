// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int sum = 0;
int[] array = GetArray(8);
Console.WriteLine($" [ {String.Join(",", array)} ] ");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях:" + sum);
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-10, 10);
        if (i % 2 != 0)
        {
            sum += result[i];
        }
    }
    return result;
}