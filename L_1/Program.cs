//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

int[] array = FillArray(12,-9,9);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}] сумма положительных = {GetSumPossitiveByArray(array)}, сумма отрицательных = {GetSumNegativeByArray(array)}");

int[] FillArray(int size, int min, int max){
    int[] result = new int[size]; // объявляем масссив с указ. размером
    Random rnd = new Random();
    for(int i = 0; i < result.Length; i++){
        result[i] = rnd.Next(min,max + 1);
    }
    return result;
}

int GetSumPossitiveByArray(int[] inputArray){
    int result = 0;
    foreach(int element in inputArray){
        result += element > 0 ? element : 0;    
         // if(element > 0) 
        //  result += element;
    }
    return result;
}

int GetSumNegativeByArray(int[] inputArray){
    int result = 0;
    foreach(int element in inputArray){
        result += element < 0 ? element : 0;
        // if(element > 0) 
        //     result += element;
    }
    return result;
}