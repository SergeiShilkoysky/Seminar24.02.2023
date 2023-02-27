// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19  /  [-4, -6, 89, 6] -> 0


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

int sumElementOddPosition(int[] array)
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

int[] array = arrayInit(6);
print(array);
Console.WriteLine($"в указанном массиве сумма элементов на нечетных позициях = {sumElementOddPosition(array)}");