// Задача 51: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int SumOnDiagonal(int[,] arr)
{
    int size = arr.GetLength(1);
    if (arr.GetLength(0) < arr.GetLength(1)) size = arr.GetLength(0);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

int SumOnDiagonalVer2(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += arr[i, j];
            }
        }
    }
    return sum;
}
int[,] rndMatrix = CreatMatrixRandomInt(5, 4, 1, 10);
PrintMatrix(rndMatrix);

int sumOnDiagonal = SumOnDiagonal(rndMatrix);
Console.WriteLine($"Сумма элементов на главной диагонали равна - {sumOnDiagonal}");