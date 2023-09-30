// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


bool IsSquareTwoNumbers(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool result = IsSquareTwoNumbers(firstNum, secondNum);
Console.WriteLine(result ? $"{firstNum}, {secondNum} -> Да" : $"{firstNum}, {secondNum} -> Нет");

