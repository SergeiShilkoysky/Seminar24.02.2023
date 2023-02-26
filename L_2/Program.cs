// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

void print(int[] array)
{
   Console.WriteLine($"[{string.Join(",",array)}]");
}
int[] arrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i=0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }
    return array;
}
int[] oppositeSignArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

Console.WriteLine("Введите разменрность массива:");
int arraySize = int.Parse(Console.ReadLine());
int[] array = arrayInit(arraySize);

print(array);
oppositeSignArray(array);
print(array);