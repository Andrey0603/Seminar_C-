// Для ДЗ


void PrintArrayDouble(double[] arr)
{
    //Console.WriteLine("[");
    for (int i = 0; i < arr.Length; i++)
    {
        //double nRound = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    //Console.WriteLine("]");
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}
