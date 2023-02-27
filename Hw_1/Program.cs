// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве. // [345, 897, 568, 234] -> 2

int[] ArrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}
int CheckEvenNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}
void Print(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] array = ArrayInit(6);
Print(array);
Console.WriteLine($"в указанном массиве колличество четных чисел = {CheckEvenNumber(array)}");