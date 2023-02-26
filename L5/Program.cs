//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3    /  [6 7 3 6] -> 36 21

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
        array[i] = rnd.Next(0,10);
    }
    return array;
}

int [] multyPairs(int[] array)
{
    int size = array.Length / 2;       // промежуточная переменная для того чтобы положить в 24 строку
    if(array.Length % 2 == 1) size ++; // для учета в середине непарного элемента, т.е если он делится с остатком то прибавляем к размерности 1. четное к-во пар
    int[] array2 = new int[size];
    for(int i =0; i < array2.Length; i++ ) // i двигается по размерности нового массива1
    {
        if (i == array.Length-i-1)
        { 
            array2[i] = array[i];
            break;
        }
        array2[i] = array[i] * array[array.Length-i-1]; 

    }
    return array2;
}

Console.WriteLine($"Введите размер массива:");
int size = int.Parse(Console.ReadLine());

int[] array = arrayInit(size);
print(array);
print(multyPairs(array));


/*int[] array = FillArray(4, 1, 9);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}]");
Console.WriteLine(
    $"Результирующий массив : [{string.Join(" ", GetCompositionValueInArray(array))}]"
);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}
int[] GetCompositionValueInArray(int[] array)
{
    int count = array.Length / 2;

    if (array.Length % 2 == 1)
    {
        count++;
    }
    int[] rezult = new int[count];
    for (int i = 0; i < count; i++)
    {
        rezult[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1)
    {
        rezult[count - 1] = array[count - 1];
    }

    return rezult;
}
*/