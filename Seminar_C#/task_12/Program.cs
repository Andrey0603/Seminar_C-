﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



// int SumNumbers (int num)
// {
    
//     int sum = 0;
//     for(int i = 1; i <= num; i++)
//     {
//         checked
//         {
//             sum = sum + i;
//         }
        
//     }
//     return sum;
// }




// Console.WriteLine("введите целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// if  (number < 1)
// { 
//     Console.WriteLine("Некорректный ввод");
//     return;
// }

// int result = SumNumbers(number);
// Console.WriteLine($"Сумма чисел от 1 до {number} -> {result}");


int Factorial (int num)
{
    
    int result = 1;
    for(int i = 1; i <= num; i++)
    {
        checked
        {
            result = result * i;
        }
        
    }
    return result;
}




Console.WriteLine("введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if  (number < 1)
{ 
    Console.WriteLine("Некорректный ввод");
    return;
}

int resultFactorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {resultFactorial}");