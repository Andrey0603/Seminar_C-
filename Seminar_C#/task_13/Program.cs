//Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; // 0 1 2 3 4 5 6 7
// int[] array1 = new int[8] { 4, 5, 7, 8, 8, 3, 3, 3 };
// int[] array2 = new int[] { 4, 5, 7, 8, 8, 3, 3, 3, 6 };
// int[] array3 = { 4, 5, 7, 8, 8, 3, 3, 3, 6 };

// var array4 = new int[8];

// // var n = 5 / 4 + 6 - 8 / 11;  ТАК НЕЛЬЗЯ!!!


// string[] arrayStr = new string[8];
// bool[] arrayBool = new bool[8];
// Random[] rndArr = new Random[8];




// array[0] = 3453;
// array[4] = 545;
// array[7] = 64;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

int[] RandomArray (int min, int max, int length)
{
    int[] arr = new int [length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = RandomArray(0, 1, 8);

PrintArray(array);
