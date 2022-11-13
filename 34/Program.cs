// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
double chet = 0;
int[] array = GetRandomArray(size, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"четных чисел: " + chet);
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        if (result[i] % 2 == 0)
        {
            chet++;
        }
    }
    return result;
}