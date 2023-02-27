// Задача 38: Задайте clear. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] ArrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 20);
    }
    return array;
}

int FindMax(int[] array)
{
    foreach (int i in array)
    {
        int max = array[i];
        if (i > max) { max = i; }
        return max;
    }
}
int FindMin(int[] array)
{
    foreach (int i in array)
    {
        int min = array[i];
        if (i < min) { min = i; }
        return min;
    }
}
void Print(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] array = ArrayInit(5);
Print(array);
Console.WriteLine($"в указанном массиве максимальное значение {FindMax(array)} - минимальное {FindMin(array)} = {FindMax(array) - FindMin(array)}");