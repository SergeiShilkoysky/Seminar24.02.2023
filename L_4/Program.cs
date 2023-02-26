// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1   /   [1, 2, 3, 6, 2] -> 0   /  [10, 11, 12, 13, 14] -> 5


int[] arrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i=0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,200);
    }
    return array;
}

int intExist(int[] array)
{
    int result = 0;
   for(int i =0; i <array.Length; i++)
   {
        if (array[i] >= 10 && array[i] <=99) result++;  
   }
   return result;
}
void print(int[] array)
{
   Console.WriteLine($"[{string.Join(",",array)}]");
}

int[] array = arrayInit(10);
print(array);
Console.WriteLine($"В данном массиве {intExist(array)} чисел диапозона ");

