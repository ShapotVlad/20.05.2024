﻿// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };

// В данной программе мы проходим по каждой строке массива, 
// считаем сумму элементов в каждой строке и обновляем минимальную сумму, если текущая сумма меньше. 
// Затем выводим индекс строки с наименьшей суммой элементов (считая от единицы).
// В вашем примере, строка с наименьшей суммой элементов - это строка с индексом 2 (считая от единицы). 😊



int[,] numbers = new int[,]
{
            {1, 2, 3},
            {1, 1, 0},
            {7, 8, 2},
            {9, 10, 11}
};

int numRows = numbers.GetLength(0);
int numCols = numbers.GetLength(1);

int minSum = int.MaxValue; // Инициализируем минимальную сумму максимальным значением

int minSumRowIndex = -1; // Инициализируем индекс строки с минимальной суммой

// Проходим по каждой строке и считаем сумму элементов
for (int row = 0; row < numRows; row++)
{
    int rowSum = 0; // Сумма элементов в текущей строке

    for (int col = 0; col < numCols; col++)
    {
        rowSum += numbers[row, col];
    }

    // Если текущая сумма меньше минимальной, обновляем значения
    if (rowSum < minSum)
    {
        minSum = rowSum;
        minSumRowIndex = row;
    }
}

// Выводим результат
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");




public static int MinIndex(int[] array)
{
    if (array == null || array.Length == 0)
        throw new ArgumentException("Массив пуст");

    int minIndex = 0;
    int minValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        }
    }

    return minIndex;
}
