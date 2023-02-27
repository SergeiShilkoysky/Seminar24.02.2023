// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементов массива.  /  [3 7 22 2 78] -> 76


double[] ArrayInit(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble()*100;
    }
    return array;
}
 double FindMaxMin(double[] array)
{
    double result = 0;
    foreach (int i in array)
    {
        result = array.Max() - array.Min();
    }
    return result;
}
void Print(double[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

double [] array = ArrayInit(4);
double [] array1 = new double [] {3, 7, 22, 2, 78};
Console.WriteLine();
Print(array);
Console.WriteLine($"в указанном массиве  максимальное {array.Max()} - минимальное {array.Min()}  = {FindMaxMin(array)}");
Console.WriteLine();
Print(array1);
Console.WriteLine($"в  массиве  максимальное {array1.Max()} - минимальное {array1.Min()} = {FindMaxMin(array1)}");
Console.WriteLine();
