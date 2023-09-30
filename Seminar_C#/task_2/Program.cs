// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



int num = new Random().Next(100, 1000);
Console.WriteLine($"На вход получаем число -> {num}");
// int firstNum = num / 100;
// int lastNum = num % 10;
// int result = firstNum * 10 + lastNum;
// Console.WriteLine($"Двухзначное число -> {result}");

int DeleteSecondDigit(int number)
{
    int firstNum = number / 100;
    int lastNum = number % 10;
    return firstNum * 10 + lastNum;
}

int res = DeleteSecondDigit(num);

Console.WriteLine(res);
