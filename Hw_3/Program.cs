// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] arrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 20);
    }
    return array;
}

int diffMaxMinElement(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
       // if (array[i] % 2 == 1) result++;
       result += array[i];
    }
    return result;
}
void print(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] array = arrayInit(5);
print(array);
Console.WriteLine($"в указанном массиве сумма элементов на нечетных позициях = {diffMaxMinElement(array)}");