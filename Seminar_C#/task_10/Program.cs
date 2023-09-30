// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SumNumbers(int num)
// {
//     int sum =0;
//     for (int i=0; i<= num; i++)
//     {
//         checked
//         {
//            sum = sum+i; 
//         }
        
//     }
//     return sum;
// }

// Console.WriteLine ("Введите целое положительное число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number <1)
// {
//   Console.WriteLine("Некорректный ввод");  
//   return;
// }

// int sumNumbers = SumNumbers(number);
// Console.WriteLine($"Сумма чисел от 1 до {number})={SumNumbers}

int SumNumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i; // sum = sum + i
        }
    }

    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");


// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CalcNUmberOfDigits(int num)
{
    if(num == 0)
        return 1;

    int counter = 0;
    while(num != 0)
    {
        counter++;
        num /= 10;
    }
    return counter;
}

int number = Prompt("Input number: ");
int numberOfDigits = CalcNUmberOfDigits(number);
Console.WriteLine($"Number of digits in {number} -> {numberOfDigits}");