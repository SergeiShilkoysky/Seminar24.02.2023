// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = FillArray(5, 6, 345);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}]");
Console.WriteLine($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (HasValueInArray(array, num))
    Console.WriteLine($"Да ");
else
    Console.WriteLine($" Нет");

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
bool HasValueInArray(int[] innumArray, int num)
{
    foreach( int element in innumArray)    // альтернатива чз for представлена ниже
        if (element == num){
           return true; 
        }
        return false;
    /*for (int i = 0; i < innumArray.Length; i++)
    {
        if (innumArray[i] == num)
            return true;
    }
    return false;
    */
}



