﻿// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите номер A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер B");
int numberB = Convert.ToInt32(Console.ReadLine());

if ((numberA/numberB)== numberB) 
{
    Console.WriteLine("Все правильно: ");
}
else 
{
     Console.WriteLine("Попробуй еще: ");
}

