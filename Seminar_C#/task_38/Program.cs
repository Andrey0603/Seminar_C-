
/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}

// Сортировка перемешиванием (шейкерная сортировка)

// void ShakerSort(vector<int>& values) {
//   if (values.empty()) {
//     return;
//   }
//   int left = 0;
//   int right = values.size() - 1;
//   while (left <= right) {
//     for (int i = right; i > left; --i) {
//       if (values[i - 1] > values[i]) {
//         swap(values[i - 1], values[i]);
//       }
//     }
//     ++left;
//     for (int i = left; i < right; ++i) {
//       if (values[i] > values[i + 1]) {
//         swap(values[i], values[i + 1]);
//       }
//     }
//     --right;
//   }
// }



// Сортировка расчёскa
// Сортировка расчёской — улучшение сортировки пузырьком. Её идея состоит в том, чтобы «устранить» элементы с небольшими значения в конце массива,
//  которые замедляют работу алгоритма. Если при пузырьковой и шейкерной сортировках при переборе массива сравниваются соседние элементы,
//  то при «расчёсывании» сначала берётся достаточно большое расстояние между сравниваемыми значениями, а потом оно сужается вплоть до минимального.

// void CombSort(vector<int>& values) {
//   const double factor = 1.247; // Фактор уменьшения
//   double step = values.size() - 1;

//   while (step >= 1) {
//     for (int i = 0; i + step < values.size(); ++i) {
//       if (values[i] > values[i + step]) {
//         swap(values[i], values[i + step]);
//       }
//     }
//     step /= factor;
//   }
//   // сортировка пузырьком
//   for (size_t idx_i = 0; idx_i + 1 < values.size(); ++idx_i) {
//     for (size_t idx_j = 0; idx_j + 1 < values.size() - idx_i; ++idx_j) {
//       if (values[idx_j + 1] < values[idx_j]) {
//         swap(values[idx_j], values[idx_j + 1]);
//       }
//     }
//   }
// }

