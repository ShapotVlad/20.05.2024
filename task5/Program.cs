﻿// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены табуляцией.

// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

        int[,] numbers = new int[,]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        // Получаем количество строк и столбцов в массиве
        int numRows = numbers.GetLength(0);
        int numCols = numbers.GetLength(1);

        // Меняем местами первую и последнюю строки
        for (int col = 0; col < numCols; col++)
        {
            int temp = numbers[0, col];
            numbers[0, col] = numbers[numRows - 1, col];
            numbers[numRows - 1, col] = temp;
        }

        // Выводим результат
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Console.Write(numbers[row, col] + "\t");
            }
            Console.WriteLine();
        }
 