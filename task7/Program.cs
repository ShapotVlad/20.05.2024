//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[] SumRows(int[,] array)
{
    int rows = array.GetLength(0); // Количество строк
    int cols = array.GetLength(1); // Количество столбцов

    int[] SumRows = new int[rows]; // Одномерный массив для сумм строк

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < cols; j++)
        {
            sum += array[i, j]; // Суммируем значения в текущей строке
        }
        SumRows[i] = sum; // Записываем сумму в одномерный массив
    }
    return SumRows;
}

int MinIndex(int[] array) // создали функцию для определения индекса строки с мин суммой
{
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


int[,] numbers = new int[,]
{
            {1, 12, 13},
            {1, 1, 20},
            {7, 8, 2},
            {9, 10, 11}
};

int[] result = SumRows(numbers);
int minIndex = MinIndex(result);

void PrintResult(int[,] numbers)
{
        Console.WriteLine(minIndex);
}
PrintResult(numbers);


